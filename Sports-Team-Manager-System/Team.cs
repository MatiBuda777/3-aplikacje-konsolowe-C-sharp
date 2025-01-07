namespace Sports_Team_Manager_System;

public class Team
{
    public List<Player> Players;
    
    public void Add(Player player)
    {
        if (Players.Contains(player)) return;
        
        Players.Add(player);
        Console.WriteLine($"Dodano gracza {player.Name}");
    }

    public void Remove(Player player)
    {
        if (!Players.Contains(player)) return;
        
        Players.Remove(player); 
        Console.WriteLine($"Usunięto gracza {player.Name}");
    }

    public void Stats()
    {
        if (Players.Count == 0) Console.WriteLine("Brak zawodników w drużynie.");
        else Players.ForEach( player => Console.WriteLine(player.ToString()) );
    }

    public static double AvgScore(List<Player> players)
    {
        if (players.Count == 0) return 0;
        
        return players.Average(player => player.Score);
    }
}