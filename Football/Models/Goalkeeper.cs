using Football.Contracts;

namespace Football.Models;

public class Goalkeeper : FootballPlayer
{
	public Goalkeeper(string name, int age, int number, int height)
		: base(name, age, number, height)
	{
	}
}
