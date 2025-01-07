namespace Sports_Team_Manager_System;

public class Player
{
    public string Name { get; set; }
    public string Position { get; set; }
    public int Score { get; set; }

    public override string ToString()
    {
        return $"{Name}, Pozycja: {Position}, Gole: {Score}";
    }

    public void UpdateScore(int points) { Score += points; }

    public static List<Player> SearchByPosition(List<Player> players, string position)
    {
        return players.Where(player => player.Position == position).ToList();
    } 
}