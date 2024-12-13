// See https://aka.ms/new-console-template for more information

namespace Board_game;

internal class Program
{
    public static Action<char> Line = (char type) => Console.WriteLine(string.Concat(Enumerable.Repeat(type, 50)));
    public static void Main(string[] args)
    {
        Random random = new();
        Board board = new(random);
        
        Console.WriteLine("Podaj swoje imię:");
        Player player1 = new(Console.ReadLine());
        player1.Info();
        
        Player[] players = new Player[]
        {
            new Player("Alice"),
            new Player("Bob"),
            new Player("Charlie")
        };

        Game.Finish(players);
    }
}