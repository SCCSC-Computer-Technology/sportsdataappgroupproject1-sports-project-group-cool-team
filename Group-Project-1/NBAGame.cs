using System;

namespace Group_Project_1
{

    public class NBAGame
    {
        public int GameID { get; set; }
        public int Season { get; set; }
        public int SeasonType { get; set; }   // 1=Regular, 2=Pre, 3=Post 

        public string Status { get; set; } = "";

        public DateTime? DateTime { get; set; }

        public string AwayTeam { get; set; } = "";
        public string HomeTeam { get; set; } = "";

        public string Matchup => $"{AwayTeam} @ {HomeTeam}"; //combine away and home team so they can be selected as one

        public int? AwayTeamScore { get; set; }
        public int? HomeTeamScore { get; set; }

        public string Channel { get; set; } = "";
    }
}