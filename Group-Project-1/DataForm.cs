using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Group_Project_1
{
    public partial class DataForm : Form
    {
        // Use ONE HttpClient
        private static readonly HttpClient _client = new HttpClient();

        private const string ApiKey = "f6d43bd8239c4fe7a38abcac1c0cb30c";

        public DataForm()
        {
            InitializeComponent();

            // Nice grid defaults
            dgvData.AutoGenerateColumns = true;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ReadOnly = true;
            dgvData.AllowUserToAddRows = false;
        }

        // ---- API CALLS (return typed lists) ----

        private async Task<List<NBATeam>> GetNBATeamsAsync()
        {
            SetApiKeyHeader();

            // If "AllTeams" 404s, change to ".../Teams"
            string url = "https://api.sportsdata.io/v3/nba/scores/json/Teams";

            string json = await _client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<List<NBATeam>>(json) ?? new List<NBATeam>();
        }

        private async Task<List<NFLTeam>> GetNFLTeamsAsync()
        {
            SetApiKeyHeader();

            // If "AllTeams" 404s, change to ".../Teams"
            string url = "https://api.sportsdata.io/v3/nfl/scores/json/Teams";

            string json = await _client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<List<NFLTeam>>(json) ?? new List<NFLTeam>();
        }

        private void SetApiKeyHeader()
        {
            const string headerName = "Ocp-Apim-Subscription-Key";

            if (_client.DefaultRequestHeaders.Contains(headerName))
                _client.DefaultRequestHeaders.Remove(headerName);

            _client.DefaultRequestHeaders.Add(headerName, ApiKey);
        }

        // ---- GO BUTTON (bind to grid) ----

        private async void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboSports.SelectedItem == null)
                {
                    MessageBox.Show("Please select a sport first.");
                    return;
                }

                string selectedSport = comboSports.SelectedItem.ToString().Trim().ToLower();

                if (selectedSport.Contains("basketball") || selectedSport.Contains("nba"))
                {
                    var nbaTeams = await GetNBATeamsAsync();
                    dgvData.DataSource = nbaTeams;

                    // Hide nested object column (optional)
                    if (dgvData.Columns["StadiumDetails"] != null)
                        dgvData.Columns["StadiumDetails"].Visible = false;
                }
                else if (selectedSport.Contains("football") || selectedSport.Contains("nfl"))
                {
                    var nflTeams = await GetNFLTeamsAsync();
                    dgvData.DataSource = nflTeams;

                    if (dgvData.Columns["StadiumDetails"] != null)
                        dgvData.Columns["StadiumDetails"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Sport not supported yet.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            lblLoggedIn.Text = "Logged in:";
            this.Hide();

            Form1 mainForm = new Form1();
            mainForm.ShowDialog();
        }
    }
}