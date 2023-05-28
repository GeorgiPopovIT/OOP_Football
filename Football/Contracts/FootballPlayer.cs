namespace Football.Contracts;

public abstract class FootballPlayer : Person
{
    protected FootballPlayer(string name, int age, int number, int height)
        : base(name, age)
    {
        Number = number;
        Height = height;
    }

    public int Number { get; set; }

    public int Height { get; set; }
}
