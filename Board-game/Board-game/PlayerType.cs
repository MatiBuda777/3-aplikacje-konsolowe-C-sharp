namespace Board_game;

public class Warrior(string name) : Player(name)
{
    // Warrior (Wojownik) - specjalizuje się w zdobywaniu dużej ilości punktów przez walkę wręcz

    public void Attack(Player attacked)
    {
        if (this.Position == 0) return;
        Program.Line('!');
        attacked.Health -= this.Strength;
        Console.WriteLine($"{this.Name} atakuje {attacked.Name}!");
        Console.WriteLine($"{attacked.Name} traci {this.Strength} PŻ i zostaje mu {attacked.Health} PŻ.");
        Program.Line('!');
    }

    public override void Info()
    {
        Program.Line('=');
        Console.Write("Wojownik ");
        base.Info();
        Program.Line('=');
    }
}

public class Archer(string name) : Player(name)
{
    // Archer (Łucznik) - specjalizuje się w zdobywaniu dużej ilości punktów przez walkę na dystans

    public void Shoot(Player attacked)
    {
        if (attacked.Position == 0) return;
        Program.Line('!');
        attacked.Health -= this.Strength / 2;
        Console.WriteLine($"{this.Name} atakuje {attacked.Name}!");
        Console.WriteLine($"{attacked.Name} traci {this.Strength} PŻ i zostaje mu {attacked.Health} PŻ.");
        Program.Line('!');
    }
    
    public override void Info()
    {
        Program.Line('=');
        Console.Write("Łucznik ");
        base.Info();
        Program.Line('=');
    }
}

public class Mage(string name) : Player(name)
{
    // Mage (Mag) - specjalizuje się w rzucaniu zaklęć, aby wpływać na grę

    public void Magic()
    {
        Random random = new();
        Console.WriteLine($"{this.Name} czaruje!");
        var rand = random.Next(1, 4);
        var points = random.Next(1, 11);
        var move = random.Next(1, 5);
        switch (rand)
        {
            case 1:
                Console.WriteLine($"{this.Name} daje sobie {rand} punktów!");
                this.Scoring(points, true);
                break;
            case 2:
                Console.WriteLine($"{this.Name} przenosi się o {move} pola do przodu!");
                this.Movement(move, true);
                break;
            case 3:
                Console.WriteLine($"{this.Name} przenosi się o {move} pola do tyłu!");
                this.Movement(move, false);
                break;
            default:
                Console.WriteLine("Łot? Nieznana liczba?");
                break;
        }
    }
    
    public override void Info()
    {
        Program.Line('=');
        Console.Write("Mag ");
        base.Info();
        Program.Line('=');
    }
}
public class Healer(string name) : Player(name)
{
    // Healer (Lekarz) - specjalizuje się w leczeniu innych graczy

    public void Heal()
    {
        Random random = new();
        int healPoints = random.Next(1, 16);
        Console.WriteLine($"{this.Name} ulecza siebie o {healPoints} punktów!");
        this.Health += healPoints;
    }
    
    public override void Info()
    {
        Program.Line('=');
        Console.Write("Lekarz ");
        base.Info();
        Program.Line('=');
    }
}