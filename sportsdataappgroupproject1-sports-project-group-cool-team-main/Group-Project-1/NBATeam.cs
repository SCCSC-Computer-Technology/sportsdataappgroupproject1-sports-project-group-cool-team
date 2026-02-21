public class NBATeam
{
    public string Key { get; set; }

    public string Name { get; set; }

    public string City { get; set; }

    public string Conference { get; set; }

    public string Division { get; set; }

    public NBAStadiumDetails StadiumDetails { get; set; }
}

public class NBAStadiumDetails
{
    public string Name { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public int Capacity { get; set; }
}