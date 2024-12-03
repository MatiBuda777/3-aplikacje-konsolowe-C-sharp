using System.Runtime.InteropServices.JavaScript;

namespace Board_game;

public class Board
{
    public int boardSize = 64;
    public List<int> prizeSpaces = new();

    public Board()
    {
        AddPrizeSpaces();
    }
    
    // generowanie pól specjalnych
    private void AddPrizeSpaces()
    {
        Random random = new Random();
        for (int i = 0; i < 12; i++)
        {
            int prizeSpace;
            do
            {
                prizeSpace = random.Next(1, 64);
            } while (prizeSpaces.Contains(prizeSpace)); // zapewnienie, że pola specjalne nie będą się powtarzać
            prizeSpaces.Add(prizeSpace);
        }
    }
    
    // generowanie nagród dla gracza
    public void Prizes(Player player)
    {
        int x = 0;
    }
}