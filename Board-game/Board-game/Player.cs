namespace Board_game;

public class Player
{
    public string name = "Jan";
    public int position = 0;
    public int score = 0;
    
    // konstruktor obiektu Player
    public Player(string name, int position, int score)
    {
        this.name = name;
        this.position = position;
        this.score = score;
    }
    
    // ruch na planszy
    public void Movement(int move)
    {
        this.position += move;
    }
    
    // zdobywanie punktów
    public void Scoring(int points)
    {
        this.score += points;
    }
}