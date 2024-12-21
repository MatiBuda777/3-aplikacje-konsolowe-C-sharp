// See https://aka.ms/new-console-template for more information

namespace Board_game;

internal class Program
{
    // funkcja liniowa do tworzenia linii do odzielania tekstu w konsoli
    public static Action<char> Line = (char type) => Console.WriteLine(string.Concat(Enumerable.Repeat(type, 50)));
    public static void Main(string[] args)
    {
        Random random = new();
        Board board = new(random);
        
        // =================== tworzenie obiektów typu Player ======================
        Console.WriteLine("Podaj swoje imię:");
        Player player1 = new(Console.ReadLine());
        player1.Info();

        // lista imion (chatGTP napisał)
        string[] names = new []
        {
            "Liam", "Noah", "Oliver", "Elijah", "James",
            "William", "Benjamin", "Lucas", "Henry", "Alexander",
            "Mia", "Emma", "Ava", "Sophia", "Isabella",
            "Charlotte", "Amelia", "Harper", "Evelyn", "Abigail",
            "Xanthe", "Balthazar", "Cressida", "Dorian", "Eulalia",
            "Ferdinand", "Ginevra", "Hesperia", "Icarus", "Jovian"
        };
        
        List<Player> players = new() // lista z graczami
        {
            player1,
            new Player(names.ElementAt(random.Next(names.Length))),
            new Player(names.ElementAt(random.Next(names.Length))),
            new Player(names.ElementAt(random.Next(names.Length))),
        };
        
        while (true) // pętla do dodawania graczy
        {
            Console.WriteLine("Czy chcesz dodać kolejnego gracza?");
            var input = Console.ReadLine().ToLower();
            if (input == "tak" || input == "ok")
            {
                var newP = new Player(names.ElementAt(random.Next(names.Length)));
                if (players.Contains(newP)) continue;
                else players.Add(newP); 
            }
            else break;
        }
        
        

        Game.Finish(players);
    }
}