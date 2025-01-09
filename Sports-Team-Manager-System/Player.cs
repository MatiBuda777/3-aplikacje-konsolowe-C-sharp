namespace Sports_Team_Manager_System;

public class Player
{
    public string Name;
    private string _position;
    public int Score;

    public Player(string name = "Bezimienny Zawodnik", string position = "Niewybrana")
    {
        Name = name;
        _position = position;
        Score = 0;
    }
    
    public Player(int score, string name = "Bezimienny Zawodnik", string position = "Niewybrana")
    {
        Name = name;
        _position = position;
        Score = score;
    }

    public override string ToString()
    {
        return $"{Name}, Pozycja: {_position}, Gole: {Score}";
    }

    public void UpdateScore()
    {
        Program.Line('=', 50);
        Console.WriteLine($"Podaj liczbę goli, które zdobył {Name}");
        int points = Convert.ToInt32(Console.ReadLine());
        Score += points;
    }

    public static List<Player> SearchByPosition(List<Player> players, string position)
    {
        return players.Where(player => player._position == position).ToList();
    } 
}