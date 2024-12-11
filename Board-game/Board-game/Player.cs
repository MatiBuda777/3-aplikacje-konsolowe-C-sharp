namespace Board_game;

public class Player
{
    public string Name = "Jan";
    public int Position;
    public int Score;
    public int Health = 50;
    public int Strength = 5;
    public int Energy = 20;
    
    // konstruktor obiektu Player
    public Player(string name)
    {
        this.Name = name;
        this.Position = 0;
        this.Score = 0;
    }
    
    // ruch na planszy
    public void Movement(int move)
    {
        if ((this.Position += move) ! >= 64) this.Position += move;
        else this.Position = 64;
    }
    
    // zdobywanie punktów
    public void Scoring(int points)
    {
        this.Score += points;
    }
}