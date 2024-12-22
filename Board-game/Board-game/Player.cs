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
        Program.Line('-');
        if (move == 0) Console.WriteLine("Brak możliwości ruchu (wyrzucone 0 na kości)");
        else if ((this.Position += move) ! >= 64) this.Position += move;
        else
        {
            this.Position = 64;
            Console.WriteLine($"Gracz {this.Name}");
        }
        Program.Line('-');
    }
    
    // zdobywanie punktów
    public void Scoring(int points)
    {
        this.Score += points;
    }
    
    public void Attack(Player attacked)
    {
        Program.Line('!');
        int attackPower = this.Strength;
        Console.WriteLine($"{this.Name} atakuje {attacked.Name}!");
        attacked.Health = attacked.Health - attackPower;
        Program.Line('!');
    }
}