using Football.Contracts;

namespace Football.Models
{
    public class Game
    {
        public Game(Team homeTeam, Team awayTeam, Referee referee,
            Referee assistant1, Referee assistant2)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Referee = referee;
            this.Assistant1 = assistant1;
            this.Assistant2 = assistant2;
        }
        public Team HomeTeam{ get; set; }

        public Team AwayTeam { get; set; }

        public Referee Referee { get; set; }

        public Referee Assistant1 { get; set; }

        public Referee Assistant2 { get; set; }

        public List<Dictionary<int,FootballPlayer>> Goals  { get; set; }
        public string Result => GetResult(); 

        public Team Winner { get; }

        public string GetResult()
        {
            int homeGoals = 0;
            int awayGoals = 0;
            foreach (var goal in Goals)
            {
                foreach (var player in goal.Values)
                {
                    if (HomeTeam.Players.Contains(player))
                    {
                        homeGoals++;
                    }
                    else
                    {
                        awayGoals++;
                    }
                }
            }
            return $"Home: {homeGoals} - Away: {awayGoals}";
        }

    }
}
