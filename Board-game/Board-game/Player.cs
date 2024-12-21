namespace Board_game;

public class Player
{
    public string Name;
    public int Position;
    public int Score;
    public int Health = 50;
    public int Strength = 5;
    public int Energy = 20;

    // konstruktor obiektu Player
    public Player(string name)
    {
        this.Name = name;
        this.Position = 0;
        this.Score = 0;
    }
    
    // info o graczu
    public void Info()
    {
        Program.Line('=');
        Console.WriteLine($"{this.Name}, {this.Score} punktów. Obecnie na polu numer {this.Position}.");
        Console.WriteLine($"HP: {this.Health}");
        Console.WriteLine($"Siła: {this.Strength}");
        Console.WriteLine($"Energia: {this.Energy}");
        Program.Line('=');
    }

    // ruch na planszy
    public void Movement(int move)
    {
        if ((this.Position += move) ! >= 64) this.Position += move;
        else this.Position = 64;
    }
    
    // zdobywanie punktów
    public void Scoring(int points)
    {
        this.Score += points;
    }
}

public class CreatePlayer : IWarrior
{
    
}