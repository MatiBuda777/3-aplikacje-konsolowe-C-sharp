using System.Runtime.CompilerServices;

namespace Board_game;
using System.Linq;

public class Game
{
    // sprawdzenie, czy pole jest specjalne
    public static void PrizeSpace(Player player, Board board)
    {
        if (!board.PrizeSpaces.Contains(player.Position)) return;
        
        Random random = new();
        var prize = random.Next(1, 6);
        var rand = random.Next(1, 11);
        var randPoints = random.Next(1, 21);
        Console.WriteLine($"{player.Name} staje na specjalnym polu numer {player.Position}");
        switch (prize)
        {
            case 1:
                player.Scoring(randPoints, true);
                break;
            case 2:
                player.Upgrade(rand, 0);
                break;
            case 3:
                player.Upgrade(rand, 1);
                break;
            case 4: 
                player.Scoring(randPoints, false);
                break;
            case 5:
                player.Upgrade(rand, 2);
                break;
            default:
                Console.WriteLine("Łot? Nieznana liczba?");
                break;
        }
    }
    
    // wyświetlenie wyników i zakończenie gry
    public static void Finish(List<Player> players, int numberOfTurns)
    {
        // tablica wyników
        Program.Line('=');
        Console.WriteLine($"Gra zakończyła się po {numberOfTurns} kolejkach");
        Console.WriteLine("Tablica wyników:");
        int i = 1;
        var playerTab = players.OrderByDescending(player => player.Score);
        foreach (var player in playerTab)
        {
            Console.WriteLine($"Miejsce {i}:");
            player.Info();
            i++;
        }
        Program.Line('=');
    }
}