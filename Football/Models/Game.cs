using Football.Contracts;

namespace Football.Models
{
    public class Game
    {
        public Game()
        {
            
        }
        public Team HomeTeam{ get; set; }

        public Team AwayTeam { get; set; }

        public Referee Referee { get; set; }

        public Referee Assistant1 { get; set; }
        public Referee Assistant2 { get; set; }



    }
}
