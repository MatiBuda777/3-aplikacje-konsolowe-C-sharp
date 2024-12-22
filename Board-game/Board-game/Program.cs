// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic.CompilerServices;

namespace Board_game;

internal class Program
{
    // ======= funkcja liniowa do tworzenia linii do odzielania tekstu w konsoli ========
    public static Action<char> Line = (char type) => Console.WriteLine(string.Concat(Enumerable.Repeat(type, 50)));
    
    // =================== funkcja AddPlayer do dodawania graczy =======================
    public static void AddPlayer(List<Player> players, Random random)
    {
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
        
        string randomName = names[random.Next(names.Length)];
        
        if (players.All(player => player.Name != randomName))
        {
            var newPlayer = new Player(randomName);
            players.Add(newPlayer);
            Console.WriteLine($"Dodano gracza {newPlayer.Name}");
        }
    }
            
    public static void Main(string[] args)
    {
        // ------------------- tworzenie planszy ------------------------------
        Random random = new();
        Board board = new(random);
        
        
        // ----------------- tworzenie obiektów typu Player ---------------------
        Console.WriteLine("Podaj swoje imię:");
        Player player1 = new(Console.ReadLine());
        player1.Info();
        
        List<Player> players = new() { player1 }; // lista z graczami
        
        // dodawanie graczy do listy
        for (int i = 0; i < 3; i++)
        {
            AddPlayer(players, random);
        }
        while (true) // pętla do dodawania graczy
        {
            Console.WriteLine("Czy chcesz dodać kolejnego gracza?");
            var input = Console.ReadLine().ToLower();
            if (input == "tak" || input == "ok")
            {
                AddPlayer(players, random);
            }
            else break;
        }

        players.OrderBy(player => Guid.NewGuid()).ToList(); // mieszanie listy graczy, aby była losowa kolejność
        
        // cykl gry
        int numberOfTurns = 0;
        while (true)
        {
            if (players.All(player => player.Position >= 64)) break; // warunek zakończenia pętli
            foreach (var player in players)
            {
                int move = random.Next(7);
                player.Movement(move); // ruch gracza po planszy
                
                Game.PrizeSpace(player, board); // sprawdzanie, czy gracz jest na polu specjalnym
            }

            numberOfTurns++;
        }
        
        // Zakończenie gry
        Game.Finish(players);
    }
}