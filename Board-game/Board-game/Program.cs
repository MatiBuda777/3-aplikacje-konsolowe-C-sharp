// See https://aka.ms/new-console-template for more information

using Board_game;

internal class Program
{
    public static void Main(string[] args)
    {
        Board board = new();
        Console.WriteLine(board.BoardSize);
        board.DisplayPrizeSpaces();
    }
}
