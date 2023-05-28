using Football.Contracts;

namespace Football.Models;

public class Team
{
    public Team(params FootballPlayer[] players)
    {
        this.Players = new List<FootballPlayer>();

        if (players.Length < 11 || players.Length > 22)
        {
            throw new IndexOutOfRangeException("The team players have to be at least 11 and maximum 22.");
        }
        this.Players.AddRange(players);
    }
    public List<FootballPlayer> Players { get;private set; }

	public Coach Coach { get; set; }

	public double AverageAgeOfTeam => this.Players.Average(p => p.Age);
}
