using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace Group_Project_1
{
    public partial class DataForm : Form
    {
        private static readonly HttpClient client = new HttpClient();

        private const string ApiKey = "f6d43bd8239c4fe7a38abcac1c0cb30c";

        public DataForm()
        {
            InitializeComponent();
        }

        // This method calls the API
        private async Task<string> GetStandingsAsync(string sport)
        {
            string url = "";

            // Decide which API endpoint to use
            if (sport == "Football")
            {
                url = "https://api.sportsdata.io/v3/nfl/scores/json/Standings";
            }
            else if (sport == "Basketball")
            {
                url = "https://api.sportsdata.io/v3/nba/scores/json/Standings";
            }
            else
            {
                throw new Exception("Please select a sport.");
            }

            // Clear headers first to avoid duplicates
            client.DefaultRequestHeaders.Clear();

            // Add your API key
            client.DefaultRequestHeaders.Add(
                "Ocp-Apim-Subscription-Key",
                ApiKey);

            // Call API
            string response = await client.GetStringAsync(url);

            return response;
        }

        private async void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                // Replace cmbSport with your ComboBox name if different
                string selectedSport = comboSports.SelectedItem.ToString();

                string json = await GetStandingsAsync(selectedSport);

                // Show result
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
