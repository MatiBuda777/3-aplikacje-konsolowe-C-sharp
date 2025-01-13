namespace Sports_Team_Manager_System;

public class Team
{
    public List<Player> Players = new List<Player>(); // do wygenerowania przez ai

    public void AddPlayer(Player player)
    {
        Players.Add(player);
    }
    
    public void Add()
    {
        Console.Write("Imię i nazwisko: ");
        string name = Console.ReadLine();
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
        switch (goal)
        {
            case 1:
                Console.Write("Podaj imię i nazwisko gracza do wyszukania: ");
                string name = Console.ReadLine();
                var player = Players.FirstOrDefault(p => p.Name == name);
                if (player != null) player.UpdateScore();
                else Console.WriteLine($"Gracz {name} nie istnieje");
                break;
            case 2:
                Console.Write("Podaj pozycję, według której wyszukasz zawodników: ");
                string position = Console.ReadLine();
                List<Player> players = Player.SearchByPosition(Players, position);
                players.ForEach(player => player.ToString());
                break;
        }
    }

    public void Filter()
    {
        Console.Write("Podaj, po czym chcesz filtrować zawodników (np. Pozycja, Punkty): ");
        string filter = Console.ReadLine().ToLower();
        List<Player> players;
        switch (filter)
        {
            case "pozycja":
                Console.WriteLine("Po jakiej pozycji?");
                string position = Console.ReadLine().ToLower();
                players = Players.Where(p => p.Position == position) as List<Player>;
                foreach (var player in players)
                {
                    Console.WriteLine(player.ToString());
                }
                break;
            
            case "punkty" or "wynik" or "gole":
                Console.WriteLine("Malejąco czy rosnąco?");
                string desc = Console.ReadLine().ToLower();
                if (desc == "malejaco" || desc == "malejąco")
                {
                    Console.WriteLine("Gracze posortowani malejąco: ");
                    players = new List<Player>(Players.OrderByDescending(player => player.Score));
                    players.ForEach(player => Console.WriteLine(player.ToString()));
                }
                else
                {
                    Console.WriteLine("Gracze posortowani rosnąco: ");
                    players = new List<Player>(Players.OrderBy(player => player.Score));
                    players.ForEach(player => Console.WriteLine(player.ToString()));
                }
                break;
            
            default:
                Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                break;
        }
    }
}