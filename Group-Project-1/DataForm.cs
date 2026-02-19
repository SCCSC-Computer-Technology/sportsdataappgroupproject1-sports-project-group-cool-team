using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        // Main method that decides which API endpoint to call
        private async Task<string> GetDataAsync(string selectedSport)
        {
            if (string.IsNullOrWhiteSpace(selectedSport))
                throw new Exception("Please select a sport.");

            string url;

            switch (selectedSport.Trim().ToLower())
            {
                case string s when s.Contains("basketball") || s.Contains("nba"):
                    // NBA standings endpoint (All Teams)
                    url = "https://api.sportsdata.io/v3/nba/scores/json/AllTeams";
                    break;

                case string s when s.Contains("football") || s.Contains("nfl"):
                    // NFL teams endpoint (AllTeams)
                    url = "https://api.sportsdata.io/v3/nfl/scores/json/AllTeams";
                    break;

                default:
                    throw new Exception($"Sport '{selectedSport}' is not supported yet.");
            }

            // Ensures API key header is set correctly
            _client.DefaultRequestHeaders.Remove("Ocp-Apim-Subscription-Key");
            _client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", ApiKey);

            HttpResponseMessage response = await _client.GetAsync(url);

            string body = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Status: {(int)response.StatusCode} {response.StatusCode}\nURL: {url}\nBody: {body}");

            return body;
        }

        // Go button click
        private async void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboSports.SelectedItem == null)
                {
                    MessageBox.Show("Please select a sport first.");
                    return;
                }

                string selectedSport = comboSports.SelectedItem.ToString();

                string json = await GetDataAsync(selectedSport);

                // For now show raw JSON
                MessageBox.Show(json, "API Response");
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
