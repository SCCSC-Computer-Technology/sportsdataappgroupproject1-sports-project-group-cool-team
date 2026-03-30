namespace Group_Project_1
{
    public class NBAPlayer
    {
        public int PlayerID { get; set; }

        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string FullName { get; set; } = "";

        public string Team { get; set; } = "";
        public string Position { get; set; } = "";

        public int? Number { get; set; }

        public string College { get; set; } = "";

        public string Height { get; set; } = "";
        public int? Weight { get; set; }

        public string BirthDate { get; set; } = "";

        public int? Experience { get; set; }
    }
}