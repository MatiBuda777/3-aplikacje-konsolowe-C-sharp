namespace Board_game;

public interface Warrior
{
    // Warrior (Wojownik) - specjalizuje się w zdobywaniu dużej ilości punktów przez walkę wręcz
    public void Attack(Player attacking, Player attacked)
    {
        Console.WriteLine($"{attacking.Name} atakuje {attacked.Name}!");
    }
}

public interface Archer
{
    // Archer (Łucznik) - specjalizuje się w zdobywaniu dużej ilości punktów przez walkę na dystans
    public void Attack(Player attacking, Player attacked)
    {
        Console.WriteLine($"{attacking.Name} atakuje {attacked.Name}!");
    }
}

public interface Mage
{
    // Mage (Mag) - specjalizuje się w rzucaniu zaklęć, aby wpływać na grę
    int Mana { get; set; }
    public void Attack(Player attacking, Player attacked)
    {
        Console.WriteLine($"{attacking.Name} atakuje {attacked.Name}!");
    }
}
public interface Healer
{
    // Healer (Lekarz) - specjalizuje się w leczeniu innych graczy
    int Mana { get; set; }
    public void Attack(Player attacking, Player attacked)
    {
        Console.WriteLine($"{attacking.Name} atakuje {attacked.Name}!");
    }

    public void Heal(Player healer, int healPoints)
    {
        Console.WriteLine($"{healer.Name} ulecza siebie o {healPoints} punktów!");
        healer.Health += healPoints;
    }
}