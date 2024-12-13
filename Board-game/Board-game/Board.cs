using System.Runtime.InteropServices.JavaScript;

namespace Board_game;

public class Board
{
    public int BoardSize = 64;
    public List<int> PrizeSpaces = new();

    public Board(Random random)
    {
        // generowanie pól specjalnych
        for (int i = 0; i < 12; i++)
        {
            int prizeSpace;
            do
            {
                prizeSpace = random.Next(1, 64);
            } while (PrizeSpaces.Contains(prizeSpace));

            PrizeSpaces.Add(prizeSpace);
        }
    }
        
    public void DisplayPrizeSpaces()
    {
        Console.WriteLine("Numery pól specjalnych:");
        foreach (var space in this.PrizeSpaces)
        {
            Console.WriteLine(space);
        }
    }
}