// See https://aka.ms/new-console-template for more information

using Board_game;


internal partial class Program
{
    public static Action<char> Line = (char type) => Console.WriteLine(string.Concat(Enumerable.Repeat(type, 50)));
    public static void Main(string[] args)
    {
        Board board = new();
        
        Player[] players = new Player[]
        {
            new Player("Alice"),
            new Player("Bob"),
            new Player("Charlie")
        };

        Game.Finish(players);
    }
}
