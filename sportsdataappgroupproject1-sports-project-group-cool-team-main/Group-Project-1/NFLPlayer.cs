using System;

namespace Group_Project_1
{
    internal class NFLPlayer
    {
        public int PlayerID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => (FirstName + " " + LastName).Trim();

        public string Team { get; set; }
        public string Position { get; set; }
        public int? Number { get; set; }

        public string College { get; set; }

        public string Height { get; set; }

        public int? Weight { get; set; }

        public DateTime? BirthDate { get; set; }
        public int? Experience { get; set; }
    }
}