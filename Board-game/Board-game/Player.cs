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
    public Player(string name, int position, int score)
    {
        this.Name = name;
        this.Position = 0;
        this.Score = 0;
    }
    
    // ruch na planszy
    public void Movement(int move)
    {
        this.Position += move;
    }
    
    // zdobywanie punktów
    public void Scoring(int points)
    {
        this.Score += points;
    }
}