using Football.Contracts;

namespace Football.Models;

public class Defender : FootballPlayer
{
	public Defender(string name, int age, int number, int height)
		: base(name, age, number, height)
	{
	}
}
