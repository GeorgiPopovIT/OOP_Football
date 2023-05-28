using Football.Contracts;

namespace Football.Models;

public class Striker : FootballPlayer
{
	public Striker(string name, int age, int number, int height)
		: base(name, age, number, height)
	{
	}
}
