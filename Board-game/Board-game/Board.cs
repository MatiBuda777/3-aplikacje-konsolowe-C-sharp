using System.Runtime.InteropServices.JavaScript;

namespace Board_game;

public class Board
{
    public int BoardSize = 64;
    public List<int> PrizeSpaces = new();

    public Board()
    {
        // generowanie pól specjalnych
        Random random = new Random();
        for (int i = 0; i < 12; i++)
        {
            int prizeSpace;
            do
            {
                prizeSpace = random.Next(1, 64);
            } while (PrizeSpaces.Contains(prizeSpace)); // zapewnienie, że pola specjalne nie będą się powtarzać

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