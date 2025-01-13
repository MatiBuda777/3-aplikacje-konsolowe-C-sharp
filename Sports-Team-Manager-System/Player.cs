namespace Sports_Team_Manager_System;

public class Player
{
    public string Name;
    public string Position;
    public int Score;

    public Player(string name = "Bezimienny Zawodnik", string position = "Niewybrana")
    {
        Name = name;
        Position = position;
        Score = 0;
    }
    
    public Player(int score, string name = "Bezimienny Zawodnik", string position = "Niewybrana")
    {
        Name = name;
        Position = position;
        Score = score;
    }

    public override string ToString()
    {
        return $"{Name}, Pozycja: {Position}, Gole: {Score}";
    }

    public void UpdateScore()
    {
        Console.WriteLine($"Podaj liczbę goli, które zdobył {Name}");
        int points = Convert.ToInt32(Console.ReadLine());
        Score += points;
    }

    public static List<Player> SearchByPosition(List<Player> players, string position)
    {
        return players.Where(player => player.Position == position).ToList();
    } 
}