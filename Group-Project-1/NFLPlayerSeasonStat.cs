namespace Group_Project_1
{
    public class NFLPlayerSeasonStat
    {
        public int PlayerID { get; set; }
        public string Name { get; set; } = "";
        public string Team { get; set; } = "";
        public string Position { get; set; } = "";

        public int? Played { get; set; }

        // Passing
        public double? PassingYards { get; set; }
        public double? PassingTouchdowns { get; set; }
        public double? PassingInterceptions { get; set; }

        // Rushing
        public double? RushingYards { get; set; }
        public double? RushingTouchdowns { get; set; }

        // Receiving
        public double? ReceivingYards { get; set; }
        public double? ReceivingTouchdowns { get; set; }

        // Defense
        public double? Tackles { get; set; }
        public double? Sacks { get; set; }
        public double? Interceptions { get; set; }
    }
}