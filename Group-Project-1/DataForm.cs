using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        //making a list of team names that can used to look up team icons
        private List<NFLTeam> _nflTeams = new List<NFLTeam>();
        private List<NBATeam> _nbaTeams = new List<NBATeam>();

        private List<NFLPlayer> _nflPlayers = new List<NFLPlayer>();
        private List<NBAPlayer> _nbaPlayers = new List<NBAPlayer>();

        private List<NFLStanding> _nflStanding = new List<NFLStanding>();
        private List<NBAStanding> _nbaStanding = new List<NBAStanding>();

        private List<NFLPlayerSeasonStat> _nflPlayerStats = new List<NFLPlayerSeasonStat>();
        private List<NBAPlayerSeasonStat> _nbaPlayerStats = new List<NBAPlayerSeasonStat>();




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

          

            LoadTeamLists();
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

        private async Task<List<NFLScheduleGame>> GetNFLGamesByWeekFinalAsync(int week) //modified to ignore week
        {
            string url = $"https://api.sportsdata.io/v3/nfl/scores/json/Scores/{FixedNFLSeason}";
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
            string iconPath = Path.Combine(Application.StartupPath, "SportIcons");//allows to change the icon

            comboCategory.Items.Clear();

            if (sport.Equals("Football", StringComparison.OrdinalIgnoreCase))
            {
                pBSport.ImageLocation = Path.Combine(iconPath, "NFL", "NFLLogo.png"); //Loads NFL Logo

                groupBoxNBAPlayerStats.Visible = false;
                groupBoxNFLPlayerStats.Visible = true;

                comboCategory.Items.Add("Teams");
                comboCategory.Items.Add("Standings");
                comboCategory.Items.Add("Games");
                comboCategory.Items.Add("Players");
                comboCategory.Items.Add("Player Season Stats");

            }
            else if (sport.Equals("Basketball", StringComparison.OrdinalIgnoreCase))
            {
                pBSport.ImageLocation = Path.Combine(iconPath, "NBA", "NBALogo.png"); //Loads NBA logo

                groupBoxNBAPlayerStats.Visible = true;
                groupBoxNFLPlayerStats.Visible = false;

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

            tCLeagues_SelectedIndexChanged(null, null);

            
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

        private void listBoxGames_SelectedIndexChanged(object sender, EventArgs e) //shows the match overviews when a listBox index is clicked
        {
            string sport = comboSports.SelectedItem.ToString();
            string iconPath = Path.Combine(Application.StartupPath, "SportIcons");

            if (sport.Equals("Football"))
            {
                lblAt.Text = "At:";

                if (listBoxGames.SelectedItem is NFLScheduleGame game)
                {
                    tBAwayTeam.Text = GetTeamCity(game.AwayTeam, sport) + " " + GetTeamName(game.AwayTeam, sport);
                    tBHomeTeam.Text = GetTeamCity(game.HomeTeam, sport) + " " + GetTeamName(game.HomeTeam, sport);
                    tBAwayScore.Text = game.AwayScore.ToString();
                    tBHomeScore.Text = game.HomeScore.ToString();
                    tBStatium.Text = game.StadiumName.ToString();
                    tBDate.Text = game.DateTime.ToString();

                    pictureBoxAway.ImageLocation = Path.Combine(iconPath, "NFL", GetTeamName(game.AwayTeam, sport) + ".png");
                    pictureBoxHome.ImageLocation = Path.Combine(iconPath, "NFL", GetTeamName(game.HomeTeam, sport) + ".png");
                }

            }
            else if (sport.Equals("Basketball"))
            {
                lblAt.Text = "On:";

                if (listBoxGames.SelectedItem is NBAGame game)
                {
                    tBAwayTeam.Text = GetTeamCity(game.AwayTeam, sport) + " " + GetTeamName(game.AwayTeam, sport);
                    tBHomeTeam.Text = GetTeamCity(game.HomeTeam, sport) + " " + GetTeamName(game.HomeTeam, sport);
                    tBAwayScore.Text = game.AwayTeamScore.ToString();
                    tBHomeScore.Text = game.HomeTeamScore.ToString();
                    tBStatium.Text = game.Channel.ToString();
                    tBDate.Text = game.DateTime.ToString();

                    pictureBoxAway.ImageLocation = Path.Combine(iconPath, "NBA", GetTeamName(game.AwayTeam, sport) + ".png");
                    pictureBoxHome.ImageLocation = Path.Combine(iconPath, "NBA", GetTeamName(game.HomeTeam, sport) + ".png");
                }
            }
        }

        private async void DataForm_Load(object sender, EventArgs e)
        { 

        }

        private async void LoadGameData() //updates a listbox based on what is selected from the comboBox, avoding the Go button
        {
            try
            {
                string sport = comboSports.SelectedItem.ToString();

                if (sport.Equals("Football"))
                {
                    int week = GetSelectedWeek();

                    var games = await GetNFLGamesByWeekFinalAsync(week);



                    /*DateTime gameDay = dateTimeGame.Value.Date;
                    var day = new List<NFLScheduleGame>();
                    foreach (var game in games)
                    {
                        if (game.DateTime.HasValue && game.DateTime.Value.Date == gameDay)
                        {
                            day.Add(game);
                        }
                    }
                    */

                    listBoxGames.DataSource = games;
                    listBoxGames.DisplayMember = "Matchup";
                }
                else if (sport.Equals("Basketball"))
                {
                    var games = await GetNBAGamesAsync();
                   /* DateTime gameDay = dateTimeGame.Value.Date;
                    var day = new List<NBAGame>();
                    foreach (var game in games)
                    {
                        if (game.DateTime.HasValue && game.DateTime.Value.Date == gameDay)
                        {
                            day.Add(game);
                        }
                    }
                   */
                    listBoxGames.DataSource = games;
                    listBoxGames.DisplayMember = "Matchup";
                }
            }
            catch
            {
                MessageBox.Show("Somthing happened in Game data");

            }

        }

        private async void LoadTeamData() //populates the listBox with team names for the team tab 
        {

            try
            {
                string sport = comboSports.SelectedItem.ToString();

                if (sport.Equals("Football"))
                {
                    int week = GetSelectedWeek();
                    var teams = await GetNFLTeamsAsync();

                    listBoxTeam.DataSource = teams;
                    listBoxTeam.DisplayMember = "Name";
                }
                else if (sport.Equals("Basketball"))
                {
                    var teams = await GetNBATeamsAsync();

                    listBoxTeam.DataSource = teams;
                    listBoxTeam.DisplayMember = "Name";
                }
            }
            catch
            {
                MessageBox.Show("Somthing happened in Team data");

            }

        }

        private async void LoadPlayerData()
        {
            try
            {
                string sport = comboSports.SelectedItem.ToString();

                if (sport.Equals("Football"))
                {
                    
                    listBoxPlayer.DataSource = _nflPlayerStats;
                    listBoxPlayer.DisplayMember = "Name";
                }
                else if (sport.Equals("Basketball"))
                {
                    
                    listBoxPlayer.DataSource = _nbaPlayerStats;
                    listBoxPlayer.DisplayMember = "Name";
                }
            }
            catch
            {
                MessageBox.Show("Somthing happened");
            }


        }

        private void LoadStandingsData()
        {
            string sport = comboSports.SelectedItem.ToString();

            if (sport.Equals("Football"))
            {

                listBoxPlayer.DataSource = _nflStanding;
                listBoxPlayer.DisplayMember = "FullName";
            }
            else if (sport.Equals("Basketball"))
            {
                listBoxPlayer.DataSource = _nbaStanding;
                listBoxPlayer.DisplayMember = "FullName";
            }

        }

        private async void LoadTeamLists() //loads the lists with the async objects, must be a Task method
        {
            try
            {
                _nflTeams = await GetNFLTeamsAsync();
                _nbaTeams = await GetNBATeamsAsync();
                _nflPlayers = await GetNFLPlayersAsync();
                _nbaPlayers = await GetNBAPlayersAsync();
                _nflStanding = await GetNFLStandingsAsync();
                _nbaStanding = await GetNBAStandingsAsync();
                _nflPlayerStats = await GetNFLPlayerSeasonStatsAsync();
                _nbaPlayerStats = await GetNBAPlayerSeasonStatsAsync();

                MessageBox.Show($"loaded {_nflTeams.Count} NFL teams and {_nbaTeams.Count} NBA teams");

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Could not load the data. API failed to connect" + Ex.Message);
            }

        }
        

        private string GetTeamCity(string abbriv, string sport) //translates an abbrviated team to the team's full text city
        {
            if (sport.Equals("Football"))
            {
                foreach (var team in _nflTeams)
                {
                    if (team.Key == abbriv)
                    {
                        return team.City;
                    }

                }
            }
            else if (sport.Equals("Basketball"))
            {
                foreach (var team in _nbaTeams)
                {
                    if (team.Key == abbriv)
                    {
                        return team.City;
                    }
                }
            }
            return abbriv;
        }

        private string GetTeamName(string abbriv, string sport) //translates an abbrviated team name to the team's full text name
        {
            if (sport.Equals("Football"))
            {
                foreach (var team in _nflTeams)
                {
                    if (team.Key == abbriv)
                    {
                        return team.Name;
                    }

                }
            }
            else if (sport.Equals("Basketball"))
            {
                foreach (var team in _nbaTeams)
                {
                    if (team.Key == abbriv)
                    {
                        return team.Name;
                    }
                }
            }
            return abbriv;
        }

        private void tCLeagues_SelectedIndexChanged(Object sender, EventArgs e) //populates the listBoxes inside the tabs
        {
            LoadGameData();
            LoadPlayerData();
            LoadTeamData();

           

        }

        private void listBoxTeam_SelectedIndexChanged(object sender, EventArgs e) //updates the tabpage when items in the listBox clicked on
        {

            string sport = comboSports.SelectedItem.ToString();
            string iconPath = Path.Combine(Application.StartupPath, "SportIcons");

            if (sport.Equals("Football"))
            {
                if (listBoxTeam.SelectedItem is NFLTeam team)
                {
                    pictureBoxTeamLogo.ImageLocation = Path.Combine(iconPath, "NFL", team.Name + ".png");

                    lblTeamName.Text = team.City + " " + team.Name;

                    tBTeamCity.Text = team.City;
                    tBTeamDivision.Text = team.Division;
                    tBTeamConference.Text = team.Conference;

                    foreach (var stat in _nflStanding)
                    {
                        if (stat.Team == team.Key)
                        {
                            tBTeamWins.Text = stat.Wins.ToString();
                            tBTeamTies.Visible = true;
                            tBTeamTies.Text = stat.Ties.ToString();
                            tBTeamLoss.Text = stat.Losses.ToString();
                            lblWinLossRating.Text = ((stat.Percentage ?? 0) * 100).ToString("F1") + "%"; ;
                            break;
                        }
                    }

                    lBTopPlayers.Items.Clear();
                    var teamStats = new List<NFLPlayerSeasonStat>();
                    foreach (var player in _nflPlayerStats)
                    {
                        if (player.Team == team.Key)
                        {
                            teamStats.Add(player);
                            //var item = new ListViewItem(player.FullName);

                            //item.SubItems.Add(player.Position);
                            //lBTopPlayers.Items.Add(item);
                        }


                    }

                    teamStats.Sort((a, b) =>
                    {
                        //double aTotal = (a.PassingYards ?? 0) + (a.RushingYards ?? 0) + (a.ReceivingYards ?? 0);
                        //double bTotal = (b.PassingYards ?? 0) + (b.RushingYards ?? 0) + (b.ReceivingYards ?? 0);
                        double aTotal = (a.PassingTouchdowns ?? 0) + (a.RushingTouchdowns ?? 0) + (a.ReceivingTouchdowns ?? 0);
                        double bTotal = (b.PassingTouchdowns ?? 0) + (b.RushingTouchdowns ?? 0) + (b.ReceivingTouchdowns ?? 0);
                        return bTotal.CompareTo(aTotal);
                    });

                    int count = 0;
                    foreach (var player in teamStats)
                    {
                        if (count >= 5) break;
                        lBTopPlayers.Items.Add($"{player.Name} - {player.Position} | Touchdowns: {(player.PassingTouchdowns ?? 0) + (player.RushingTouchdowns ?? 0) + (player.ReceivingTouchdowns ?? 0)} | Yds: {(player.PassingYards ?? 0) + (player.RushingYards ?? 0) + (player.ReceivingYards ?? 0)}");
                        count++;
                    }
                }

            }
            else if (sport.Equals("Basketball"))
            {
                if (listBoxTeam.SelectedItem is NBATeam team)
                {
                    pictureBoxTeamLogo.ImageLocation = Path.Combine(iconPath, "NBA", team.Name + ".png");

                    tBTeamCity.Text = team.City;
                    tBTeamDivision.Text = team.Division;
                    tBTeamConference.Text = team.Conference;

                    foreach (var stat in _nbaStanding)
                    {
                        if (stat.Key == team.Key)
                        {
                            tBTeamWins.Text = stat.Wins.ToString();
                            tBTeamTies.Visible = false;
                            tBTeamLoss.Text = stat.Losses.ToString();
                            lblWinLossRating.Text = (stat.Percentage * 100).ToString("F1") + "%";

                            break;
                        }
                    }


                    lBTopPlayers.Items.Clear();
                    var teamStats = new List<NBAPlayerSeasonStat>();
                    foreach (var player in _nbaPlayerStats)
                    {
                        if (player.Team == team.Key)
                        {
                            teamStats.Add(player);
                        }
                        //var item = new ListViewItem(player.FullName);

                        //item.SubItems.Add(player.Position);
                        //lBTopPlayers.Items.Add(item);
                    }


                    teamStats.Sort((a, b) =>
                    {
                        double aPoints = a.Points ?? 0;
                        double bPoints = b.Points ?? 0;
                        return bPoints.CompareTo(aPoints);
                    });


                    int count = 0;
                    foreach (var player in teamStats)
                    {
                        if (count >= 5) break;
                        lBTopPlayers.Items.Add($"{player.Name} - {player.Position} | PTS: {player.Points ?? 0} AST: {player.Assists ?? 0} REB: {player.Rebounds ?? 0}");
                        count++;
                    }
                }


            }


        }

        private void dateTimeGame_ValueChanged(Object sender, EventArgs e)
        {
            LoadGameData();
        }

        private void listBoxPlayer_SelectedIndexChanged(object sender, EventArgs e) //populates the player listbox and all fields therein
        {
            string sport = comboSports.SelectedItem.ToString();

            if (sport.Equals("Football"))
            {
                if (listBoxPlayer.SelectedItem is NFLPlayerSeasonStat player)
                {
                    lblPlayerName.Text = player.Name;
                    tBPlayerTeam.Text = GetTeamCity(player.Team, sport) + " " + GetTeamName(player.Team, sport);
                    tbPlayerPosition.Text = player.Position;

                    

                    groupBoxNFLPlayerStats.Visible = true;
                    groupBoxNBAPlayerStats.Visible = false;

                    // TDowns
                    tBNFLTDPassing.Text = (player.PassingTouchdowns ?? 0).ToString();
                    tBNFLTDRushing.Text = (player.RushingTouchdowns ?? 0).ToString();
                    tBNFLTDReceiving.Text = (player.ReceivingTouchdowns ?? 0).ToString();

                    // Yards
                    tBNFLYPassing.Text = (player.PassingYards ?? 0).ToString();
                    tBNFLYRushing.Text = (player.RushingYards ?? 0).ToString();
                    tBNFLYReceiving.Text = (player.ReceivingYards ?? 0).ToString();

                    // Defense
                    tBNFLTackles.Text = (player.Tackles ?? 0).ToString();
                    tBNFLSacks.Text = (player.Sacks ?? 0).ToString();
                    tBNFLInterceptions.Text = (player.Interceptions ?? 0).ToString();
                }
            }
            else if (sport.Equals("Basketball"))
            {
                if (listBoxPlayer.SelectedItem is NBAPlayerSeasonStat player)
                {
                    lblPlayerName.Text = player.Name;
                    tBPlayerTeam.Text = GetTeamCity(player.Team, sport) + " " + GetTeamName(player.Team, sport);
                    tbPlayerPosition.Text = player.Position;


                    groupBoxNBAPlayerStats.Visible = true;
                    groupBoxNFLPlayerStats.Visible = false;

                    // Stats
                    tBNBAPoints.Text = (player.Points ?? 0).ToString();
                    tBNBAAssists.Text = (player.Assists ?? 0).ToString();
                    tBNBARebounds.Text = (player.Rebounds ?? 0).ToString();
                    tBNBASteals.Text = (player.Steals ?? 0).ToString();
                    tBNBABlocks.Text = (player.BlockedShots ?? 0).ToString();
                    tBNBATurnovers.Text = (player.Turnovers ?? 0).ToString();
                    tBNBAThreePointers.Text = (player.ThreePointersMade ?? 0).ToString();
                    tBNBAFreeThrowsAttempt.Text = (player.FreeThrowsAttempted ?? 0).ToString();
                    tBNBAFreeThrowsMade.Text = (player.FreeThrowsMade ?? 0).ToString();
                }
            }
        }

        


    }
    
}
