namespace Board_game;

// Nie wiem, jak zaimplementować jeden interfejs do jednego obiektu, więc nie robię tego *****
public interface IWarrior
{
    // Warrior (Wojownik) - specjalizuje się w zdobywaniu dużej ilości punktów przez walkę wręcz
}

public interface IArcher
{
    // Archer (Łucznik) - specjalizuje się w zdobywaniu dużej ilości punktów przez walkę na dystans
}

public interface IMage
{
    // Mage (Mag) - specjalizuje się w rzucaniu zaklęć, aby wpływać na grę
    public void Magic(Player mage, Random random)
    {
        Console.WriteLine($"{mage.Name} czaruje!");
        var rand = random.Next(1, 4);
        var points = random.Next(1, 11);
        var move = random.Next(1, 5);
        switch (rand)
        {
            case 1:
                Console.WriteLine($"{mage.Name} wyczarowuje {rand} punktów!");
                mage.Score += points;
                break;
            case 2:
                Console.WriteLine($"{mage.Name} przenosi się o {move} pola do przodu!");
                mage.Position += move;
                break;
            case 3:
                Console.WriteLine($"{mage.Name} przenosi się o {move} pola do tyłu!");
                mage.Position += move;
                break;
            default:
                Console.WriteLine("Łot? Nieznana liczba?");
                break;
        }
    }
}
public interface IHealer
{
    // Healer (Lekarz) - specjalizuje się w leczeniu innych graczy
    public void Heal(Player healer, Random random)
    {
        var healPoints = random.Next(1, 16);
        Console.WriteLine($"{healer.Name} ulecza siebie o {healPoints} punktów!");
        healer.Health += healPoints;
    }
}