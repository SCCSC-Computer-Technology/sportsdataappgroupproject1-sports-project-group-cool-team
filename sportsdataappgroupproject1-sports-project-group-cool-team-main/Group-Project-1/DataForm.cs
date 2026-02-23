using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_1
{
    public partial class DataForm : Form
    {
        // store class info
        private User _loggedInUser;

        //API Key
        private static readonly HttpClient _client = new HttpClient();
        private const string ApiKey = "f6d43bd8239c4fe7a38abcac1c0cb30c";

        // Fixed year/season
        private const string FixedYear = "2025";
        private const string FixedNFLSeason = "2025REG";

        // Keep last loaded list so Search can filter it
        private object _lastLoadedData = null;

        public DataForm(User user)
        {
            InitializeComponent();

            // ✅ user-related fix (null-safe)
            _loggedInUser = user;

            // If user is null for any reason, don't crash
            if (_loggedInUser != null)
                lblLoggedIn.Text = $"Logged in as: {_loggedInUser.Username}";
            else
                lblLoggedIn.Text = "Logged in as: (unknown)";


            // Grid defaults
            dgvData.AutoGenerateColumns = true;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ReadOnly = true;
            dgvData.AllowUserToAddRows = false;
            dgvData.RowHeadersVisible = false;

            // Sport dropdown
            comboSports.Items.Clear();
            comboSports.Items.Add("Football");
            comboSports.Items.Add("Basketball");
            comboSports.SelectedIndex = 0;

            // Year dropdown locked to 2025 because the API I have doesnt allow historical data for everything.
            // We can figure this out after the app is funcitonal and nice
            if (comboYear != null)
            {
                comboYear.Items.Clear();
                comboYear.Items.Add(FixedYear);
                comboYear.SelectedIndex = 0;
                comboYear.Enabled = false;
            }

            // Week dropdown 
            comboWeek.Items.Clear();
            for (int i = 1; i <= 18; i++)
                comboWeek.Items.Add(i);
            comboWeek.SelectedIndex = 0;

            comboCategory.Items.Clear();

            // Events
            comboSports.SelectedIndexChanged += comboSports_SelectedIndexChanged;
            comboCategory.SelectedIndexChanged += comboCategory_SelectedIndexChanged;
            txtSearch.TextChanged += txtSearch_TextChanged;

            // Initialize categories + visibility
            comboSports_SelectedIndexChanged(null, null);
        }

        public DataForm() : this(null)
        {
        }

        // API Helpers
        private void SetApiKeyHeader()
        {
            const string headerName = "Ocp-Apim-Subscription-Key";

            if (_client.DefaultRequestHeaders.Contains(headerName))
                _client.DefaultRequestHeaders.Remove(headerName);

            _client.DefaultRequestHeaders.Add(headerName, ApiKey);
        }

        private async Task<string> GetJsonAsync(string url)
        {
            SetApiKeyHeader();

            HttpResponseMessage response = await _client.GetAsync(url);
            string body = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Status: {(int)response.StatusCode} {response.StatusCode}\nURL: {url}\nBody: {body}");

            return body;
        }

        private int GetSelectedWeek()
        {
            if (comboWeek.SelectedItem == null) return 1;
            return Convert.ToInt32(comboWeek.SelectedItem);
        }

        // Sort by player/team name if available, otherwise fallback
        // Search = searches ALL columns 
        private string GetSortKey(object obj)
        {
            // Prefer these fields first if they exist
            string TryProp(string propName)
            {
                var p = obj.GetType().GetProperty(propName);
                if (p == null) return "";
                var v = p.GetValue(obj);
                return v?.ToString() ?? "";
            }

            string fullName = TryProp("FullName");
            if (!string.IsNullOrWhiteSpace(fullName)) return fullName.Trim().ToLowerInvariant();

            string name = TryProp("Name");
            if (!string.IsNullOrWhiteSpace(name)) return name.Trim().ToLowerInvariant();

            string team = TryProp("Team");
            if (!string.IsNullOrWhiteSpace(team)) return team.Trim().ToLowerInvariant();

            string key = TryProp("Key");
            if (!string.IsNullOrWhiteSpace(key)) return key.Trim().ToLowerInvariant();

            // Fallback (games)
            string away = TryProp("AwayTeam");
            string home = TryProp("HomeTeam");
            return $"{away} {home}".Trim().ToLowerInvariant();
        }

        private void BindAndSort<T>(List<T> data)
        {
            data.Sort((a, b) =>
                string.Compare(GetSortKey(a), GetSortKey(b), StringComparison.OrdinalIgnoreCase));

            _lastLoadedData = data;
            dgvData.DataSource = data;
        }

        // Builds one big string from all public properties
        private string BuildAllFieldsSearchText(object obj)
        {
            if (obj == null) return "";

            var props = obj.GetType().GetProperties();
            var parts = new List<string>(props.Length);

            foreach (var p in props)
            {
                try
                {
                    object val = p.GetValue(obj);
                    if (val == null) continue;

                    // Don't explode the search text with nested objects
                    // Only include primitives/strings/dates/numbers/bools
                    Type t = val.GetType();
                    bool simple =
                        t.IsPrimitive ||
                        t == typeof(string) ||
                        t == typeof(decimal) ||
                        t == typeof(DateTime) ||
                        t == typeof(DateTime?) ||
                        t == typeof(Guid);

                    if (simple)
                        parts.Add(val.ToString());
                }
                catch
                {
                    // ignore property read errors
                }
            }

            return string.Join(" ", parts).ToLowerInvariant();
        }

        // NFL API calls
        private async Task<List<NFLTeam>> GetNFLTeamsAsync()
        {
            string url = "https://api.sportsdata.io/v3/nfl/scores/json/Teams";
            string json = await GetJsonAsync(url);
            return JsonConvert.DeserializeObject<List<NFLTeam>>(json) ?? new List<NFLTeam>();
        }

        private async Task<List<NFLStanding>> GetNFLStandingsAsync()
        {
            string url = $"https://api.sportsdata.io/v3/nfl/scores/json/Standings/{FixedNFLSeason}";
            string json = await GetJsonAsync(url);
            return JsonConvert.DeserializeObject<List<NFLStanding>>(json) ?? new List<NFLStanding>();
        }

        private async Task<List<NFLScheduleGame>> GetNFLGamesByWeekFinalAsync(int week)
        {
            string url = $"https://api.sportsdata.io/v3/nfl/scores/json/ScoresByWeekFinal/{FixedNFLSeason}/{week}";
            string json = await GetJsonAsync(url);
            return JsonConvert.DeserializeObject<List<NFLScheduleGame>>(json) ?? new List<NFLScheduleGame>();
        }

        private async Task<List<NFLPlayer>> GetNFLPlayersAsync()
        {
            string url = "https://api.sportsdata.io/v3/nfl/scores/json/PlayersByAvailable";
            string json = await GetJsonAsync(url);
            return JsonConvert.DeserializeObject<List<NFLPlayer>>(json) ?? new List<NFLPlayer>();
        }

        private async Task<List<NFLPlayerSeasonStat>> GetNFLPlayerSeasonStatsAsync()
        {
            string url = $"https://api.sportsdata.io/v3/nfl/stats/json/PlayerSeasonStats/{FixedNFLSeason}";
            string json = await GetJsonAsync(url);
            return JsonConvert.DeserializeObject<List<NFLPlayerSeasonStat>>(json) ?? new List<NFLPlayerSeasonStat>();
        }

        // NBA API calls
        private async Task<List<NBATeam>> GetNBATeamsAsync()
        {
            string url = "https://api.sportsdata.io/v3/nba/scores/json/Teams";
            string json = await GetJsonAsync(url);
            return JsonConvert.DeserializeObject<List<NBATeam>>(json) ?? new List<NBATeam>();
        }

        private async Task<List<NBAStanding>> GetNBAStandingsAsync()
        {
            string url = $"https://api.sportsdata.io/v3/nba/scores/json/Standings/{FixedYear}";
            string json = await GetJsonAsync(url);
            return JsonConvert.DeserializeObject<List<NBAStanding>>(json) ?? new List<NBAStanding>();
        }

        private async Task<List<NBAGame>> GetNBAGamesAsync()
        {
            string url = $"https://api.sportsdata.io/v3/nba/scores/json/Games/{FixedYear}";
            string json = await GetJsonAsync(url);
            return JsonConvert.DeserializeObject<List<NBAGame>>(json) ?? new List<NBAGame>();
        }

        private async Task<List<NBAPlayer>> GetNBAPlayersAsync()
        {
            string url = "https://api.sportsdata.io/v3/nba/scores/json/Players";
            string json = await GetJsonAsync(url);
            return JsonConvert.DeserializeObject<List<NBAPlayer>>(json) ?? new List<NBAPlayer>();
        }


        private async Task<List<NBAPlayerSeasonStat>> GetNBAPlayerSeasonStatsAsync()
        {
            string url = $"https://api.sportsdata.io/v3/nba/stats/json/PlayerSeasonStats/{FixedYear}";
            string json = await GetJsonAsync(url);
            return JsonConvert.DeserializeObject<List<NBAPlayerSeasonStat>>(json) ?? new List<NBAPlayerSeasonStat>();
        }

        //Sport change rebuild categories
        private void comboSports_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sport = comboSports.SelectedItem?.ToString() ?? "Football";

            comboCategory.Items.Clear();

            if (sport.Equals("Football", StringComparison.OrdinalIgnoreCase))
            {
                comboCategory.Items.Add("Teams");
                comboCategory.Items.Add("Standings");
                comboCategory.Items.Add("Games");
                comboCategory.Items.Add("Players");
                comboCategory.Items.Add("Player Season Stats");
            }
            else if (sport.Equals("Basketball", StringComparison.OrdinalIgnoreCase))
            {
                comboCategory.Items.Add("Teams");
                comboCategory.Items.Add("Standings");
                comboCategory.Items.Add("Games");
                comboCategory.Items.Add("Players");
                comboCategory.Items.Add("Player Season Stats"); 
            }

            comboCategory.SelectedIndex = 0;
            comboCategory_SelectedIndexChanged(null, null);

            _lastLoadedData = null;
            dgvData.DataSource = null;
            txtSearch.Clear();
        }

        // Week visible only for NFL Games
        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sport = comboSports.SelectedItem?.ToString() ?? "Football";
            string category = comboCategory.SelectedItem?.ToString() ?? "";

            bool showWeek =
                sport.Equals("Football", StringComparison.OrdinalIgnoreCase) &&
                category.Equals("Games", StringComparison.OrdinalIgnoreCase);

            comboWeek.Visible = showWeek;
            if (labelWeek != null) labelWeek.Visible = showWeek;
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            if (_lastLoadedData != null)
                dgvData.DataSource = _lastLoadedData;
        }

        // searches anything in any category
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_lastLoadedData == null) return;

            string q = (txtSearch.Text ?? "").Trim();

            if (q.Length == 0)
            {
                dgvData.DataSource = _lastLoadedData;
                return;
            }

            string qLower = q.ToLowerInvariant();

            if (!(_lastLoadedData is System.Collections.IList list)) return;

            var filtered = new List<object>();

            foreach (var item in list)
            {
                if (item == null) continue;

                string haystack = BuildAllFieldsSearchText(item);
                if (haystack.Contains(qLower))
                    filtered.Add(item);
            }

            // sort filtered results
            filtered.Sort((a, b) =>
                string.Compare(GetSortKey(a), GetSortKey(b), StringComparison.OrdinalIgnoreCase));

            dgvData.DataSource = filtered;
        }

        // GO button (Loads + Sorts)
        private async void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboSports.SelectedItem == null || comboCategory.SelectedItem == null)
                {
                    MessageBox.Show("Pick a Sport and Category.");
                    return;
                }

                string sport = comboSports.SelectedItem.ToString();
                string category = comboCategory.SelectedItem.ToString();

                // FOOTBALL
                if (sport.Equals("Football", StringComparison.OrdinalIgnoreCase))
                {
                    if (category.Equals("Teams", StringComparison.OrdinalIgnoreCase))
                    {
                        var data = await GetNFLTeamsAsync();
                        BindAndSort(data);
                    }
                    else if (category.Equals("Standings", StringComparison.OrdinalIgnoreCase))
                    {
                        var data = await GetNFLStandingsAsync();
                        BindAndSort(data);
                    }
                    else if (category.Equals("Games", StringComparison.OrdinalIgnoreCase))
                    {
                        int week = GetSelectedWeek();
                        var data = await GetNFLGamesByWeekFinalAsync(week);
                        BindAndSort(data);

                        if (dgvData.Columns["StadiumDetails"] != null)
                            dgvData.Columns["StadiumDetails"].Visible = false;
                    }
                    else if (category.Equals("Players", StringComparison.OrdinalIgnoreCase))
                    {
                        var data = await GetNFLPlayersAsync();
                        BindAndSort(data);
                    }
                    else if (category.Equals("Player Season Stats", StringComparison.OrdinalIgnoreCase))
                    {
                        var data = await GetNFLPlayerSeasonStatsAsync();
                        BindAndSort(data);
                    }
                    else
                    {
                        MessageBox.Show("Unknown Football category.");
                        return;
                    }
                }

                // BASKETBALL
                else if (sport.Equals("Basketball", StringComparison.OrdinalIgnoreCase))
                {
                    if (category.Equals("Teams", StringComparison.OrdinalIgnoreCase))
                    {
                        var data = await GetNBATeamsAsync();
                        BindAndSort(data);
                    }
                    else if (category.Equals("Standings", StringComparison.OrdinalIgnoreCase))
                    {
                        var data = await GetNBAStandingsAsync();
                        BindAndSort(data);
                    }
                    else if (category.Equals("Games", StringComparison.OrdinalIgnoreCase))
                    {
                        var data = await GetNBAGamesAsync();
                        BindAndSort(data);
                    }
                    else if (category.Equals("Players", StringComparison.OrdinalIgnoreCase))
                    {
                        var data = await GetNBAPlayersAsync();
                        BindAndSort(data);
                    }
                    else if (category.Equals("Player Season Stats", StringComparison.OrdinalIgnoreCase))
                    {
                        var data = await GetNBAPlayerSeasonStatsAsync();
                        BindAndSort(data);
                    }
                    else
                    {
                        MessageBox.Show("Unknown Basketball category.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Unknown sport.");
                    return;
                }

                // Apply search immediately if user already typed something
                txtSearch_TextChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data:\n\n" + ex.Message);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}