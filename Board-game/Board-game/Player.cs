namespace Board_game;

public abstract class Player() 
{
    // konstruktor obiektu Player
    protected Player(string name) : this()
    {
        this.Name = name;
    }

    public string Name { get; set; }
    public int Position { get; set; } = 0;
    public int Score { get; set; } = 0;
    public int Health { get; set; } = 50;
    public int Strength { get; set; } = 5;
    public int Energy { get; set; } = 20;

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
    public void Movement(int move, bool forward)
    {
        Program.Line('-');
        string direction = forward ? "przodu" : "tyłu";
        if (forward) this.Position += move;
        else this.Position -= move;
        
        if (this.Position < 0) this.Position = 0;
        if (this.Position > 64) this.Position = 64;
        if (this.Position == 64) Console.WriteLine($"{this.Name} ukończył grę.");
        else if (move == 0) Console.WriteLine($"{this.Name} nie rusza się (wyrzucone 0 na kości).");
        else Console.WriteLine($"{this.Name} przesuwa się o {move} pola do {direction}.");
        Console.WriteLine($"Jest na polu numer {this.Position}.");
        Program.Line('-');
    }
    
    // zdobywanie punktów
    public void Scoring(int points, bool add)
    {
        if (add)
        {
            this.Score += points; 
            Console.WriteLine($"{this.Name} zdobywa punkty! +{points} punktów.\n{this.Name} - {this.Score} punktów.");
        }
        else
        {
            this.Score -= points; 
            Console.WriteLine($"{this.Name} traci część punktów! -{points} punktów.\n{this.Name} - {this.Score} punktów.");
        }
    }
    
    public void Fight(Player attacked)
    {
        if (this.Position == 0) return;
        Program.Line('!');
        attacked.Health -= this.Strength;
        Console.WriteLine($"{this.Name} atakuje {attacked.Name}!");
        Console.WriteLine($"{attacked.Name} traci {this.Strength} PŻ i zostaje mu {attacked.Health} PŻ.");
        Program.Line('!');
    }

    public void Upgrade(int value, int type)
    {
        if (type == 0)
        {
            this.Health += value;
            Console.WriteLine($"Punkty Życia gracza {this.Name} rosną! +{value} PŻ.\n{this.Name} - {this.Health} PŻ.");

        }
        else if (type == 1)
        {
            this.Strength += value;
            Console.WriteLine($"Siła gracza {this.Name} rośnie! +{value} siły.\n{this.Name} - {this.Strength} siły.");
        }
        else if (type == 2)
        {
            this.Energy += value;
            Console.WriteLine($"Energia gracza {this.Name} powraca! +{value} energii.\n{this.Name} - {this.Energy} energii.");
        }
    }
}