using Football.Contracts;

namespace Football.Models;

public class Midfield : FootballPlayer
{
	public Midfield(string name, int age, int number, int height)
		: base(name, age, number, height)
	{
	}
}
