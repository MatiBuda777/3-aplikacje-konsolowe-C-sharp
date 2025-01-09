namespace Sports_Team_Manager_System;

public class Team
{
    public List<Player> Players;
    
    public void Add()
    {
        Console.Write("Imię i nazwisko: ");
        string name = Console.ReadLine();
        //Console.WriteLine();
        Console.Write("Pozycja: ");
        string position = Console.ReadLine();
        Player player = new(name, position);
        
        if (Players.Contains(player)) Console.WriteLine($"Gracz {player.Name} już istnieje");
        else
        {
            Players.Add(player);
            Console.WriteLine($"Dodano gracza {player.Name}");
        }
        
    }

    public void Remove()
    {
        Console.Write("Podaj imię i nazwisko: ");
        string name = Console.ReadLine();
        var player = Players.FirstOrDefault(p => p.Name == name);
        if (player == null) Console.WriteLine($"Gracz {player.Name} nie istnieje");
        else
        {
            Players.Remove(player); 
            Console.WriteLine($"Usunięto gracza {player.Name}");
        }
    }

    public void Stats()
    {
        if (Players.Count == 0) Console.WriteLine("Brak zawodników w drużynie.");
        else Players.ForEach( player => Console.WriteLine(player.ToString()) );
    }

    public static double AvgScore(List<Player> players)
    {
        if (players.Count !> 0) return 0;
        
        return players.Average(player => player.Score);
    }
    
    public void Search(int goal)
    {
        Console.Write("Podaj imię i nazwisko gracza do wyszukania: ");
        string name = Console.ReadLine();
        var player = Players.FirstOrDefault(p => p.Name == name);
        if (player != null)
            switch (goal)
            {
                case 1:
                    player.UpdateScore();
                    break;
                case 2:
                    Console.Write("Podaj pozycję, według której wyszukasz zawodników: ");
                    string position = Console.ReadLine();
                    Player.SearchByPosition(Players, position).ToString();
                    break;
            }
        else
            Console.WriteLine($"Gracz {name} nie istnieje");
    }

    public void Filter()
    {
        
    }
}