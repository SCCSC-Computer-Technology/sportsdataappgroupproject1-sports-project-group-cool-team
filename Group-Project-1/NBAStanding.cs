using Newtonsoft.Json;

namespace Group_Project_1
{
    public class NBAStanding
    {
        // Basic team info
        public int TeamID { get; set; }
        public string Key { get; set; } = "";
        public string City { get; set; } = "";
        public string Name { get; set; } = "";
        public string Conference { get; set; } = "";
        public string Division { get; set; } = "";

        // Overall record
        public int Wins { get; set; }
        public int Losses { get; set; }
        public double Percentage { get; set; }

        // Conference record
        public int ConferenceWins { get; set; }
        public int ConferenceLosses { get; set; }

        // Division record
        public int DivisionWins { get; set; }
        public int DivisionLosses { get; set; }

        // Home / Away
        public int HomeWins { get; set; }
        public int HomeLosses { get; set; }
        public int AwayWins { get; set; }
        public int AwayLosses { get; set; }

        // Last 10 games
        public int LastTenWins { get; set; }
        public int LastTenLosses { get; set; }

        // Streak info
        public int Streak { get; set; }

        // Ranking
        public int ConferenceRank { get; set; }
        public int DivisionRank { get; set; }

        // Scoring
        public double PointsPerGameFor { get; set; }
        public double PointsPerGameAgainst { get; set; }

        // Playoff indicator
        public bool ClinchedPlayoffBirth { get; set; }
    }
}