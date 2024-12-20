using System.Runtime.CompilerServices;

namespace Board_game;
using System.Linq;

public class Game
{
    // sprawdzenie, czy pole jest specjalne
    public static void PrizeSpace(Player player, Board board)
    {
        if (!board.PrizeSpaces.Contains(player.Position)) return;
        
        Random random = new Random();
        var prize = random.Next(1, 5);
        var rand = random.Next(1, 11);
        var randPoints = random.Next(1, 21);
        Console.WriteLine($"Stajesz na specjalnym polu numer {player.Position}");
        switch (prize)
        {
            case 1:
                Console.WriteLine($"Otrzymujesz dodatkowe punkty! +{randPoints} punktów.");
                player.Score += randPoints;
                break;
            case 2:
                Console.WriteLine($"Twoja siła rośnie! +{rand} siły.");
                player.Strength += rand;
                break;
            case 3:
                Console.WriteLine($"Twoja energia powraca! +{rand} energii.");
                player.Energy += rand;
                break;
            case 4:
                Console.WriteLine($"Tracisz część swoich punktów! -{randPoints} punktów.");
                player.Score -= randPoints;
                break;
            default:
                Console.WriteLine("Łot? Nieznana liczba?");
                break;
        }
    }
    
    // wyświetlenie wyników i zakończenie gry
    public static void Finish(List<Player> players)
    {
        // tablica wyników
        Program.Line('=');
        Console.WriteLine("Tablica wyników:");
        var i = 1;
        var playerTab = players.OrderByDescending(player => player.Score);
        foreach (var player in playerTab)
        {
            Console.WriteLine($"{i}. {player.Name}, {player.Score} punktów.");
            i++;
        }
        Program.Line('=');
    }
}