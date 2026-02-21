using System;

namespace Group_Project_1
{
    internal class NFLScheduleGame
    {
        public int GameID { get; set; }
        public string Season { get; set; }
        public int SeasonType { get; set; }
        public int Week { get; set; }

        public DateTime? DateTime { get; set; }
        public string Status { get; set; }

        public string AwayTeam { get; set; }
        public string HomeTeam { get; set; }

        public int? AwayScore { get; set; }
        public int? HomeScore { get; set; }

        public string Channel { get; set; }

        public StadiumDetails StadiumDetails { get; set; }

        // Helper display field
        public string Matchup
        {
            get { return AwayTeam + " @ " + HomeTeam; }
        }

        // display without showing the full StadiumDetails column
        public string StadiumName
        {
            get { return StadiumDetails != null ? StadiumDetails.Name : ""; }
        }
    }

    internal class StadiumDetails
    {
        public int StadiumID { get; set; }
        public string Name { get; set; }

        public string City { get; set; }
        public string State { get; set; }

        public int? Capacity { get; set; }
        public string PlayingSurface { get; set; }
    }
}