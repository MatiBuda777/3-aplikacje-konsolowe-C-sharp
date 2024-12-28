// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic.CompilerServices;
using System.Threading.Tasks;

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
        int randomIndex = random.Next(1, 5);
        
        
        if (players.All(player => player.Name != randomName))
        {
            string newPlayer;
            switch (randomIndex)
            {
                case 1:
                    newPlayer = new Warrior(randomName);
                    break;
                case 2:
                    newPlayer = new Archer(randomName);
                    break;
                case 3:
                    newPlayer = new Mage(randomName);
                    break;
                case 4:
                    newPlayer = new Healer(randomName);
                    break;
                default:
                    Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
                    return;
            }
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
        string name = Console.ReadLine();
        Console.WriteLine("Wybierz typ gracza:" +
                          "\n1 - Wojownik" +
                          "\n2 - Łucznik" +
                          "\n3 - Mag" +
                          "\n4 - Lekarz");
        int choice = Convert.ToInt32(Console.ReadLine());
        Player player1;
        
        switch (choice)
        {
            case 1:
                player1 = new Warrior(name);
                break;
            case 2:
                player1 = new Archer(name);
                break;
            case 3:
                player1 = new Mage(name);
                break;
            case 4:
                player1 = new Healer(name);
                break;
            default:
                Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
                return;
        }
        
        List<Player> players = new() {  }; // lista z graczami
        List<Player> playersFinished = new List<Player>(); // lista z graczami, którzy ukończyli grę w jakiś sposób (brak życia lub pole 64)
        
        
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
        Console.WriteLine("Gra się rozpoczyna!");
        
        Thread.Sleep(2000);
        
        // cykl gry
        int numberOfTurns = 0;
        while (true)
        {
            // warunek ukończenia planszy przez gracza
            foreach (var player in players)
            {
                if (player.Health <= 0 || player.Position >= 64) playersFinished.Add(player);
            }
            foreach (var player in playersFinished)
            {
                players.Remove(player);
            }
            
            if (players.Count == 0) break; // warunek zakończenia pętli
            
            // przebieg gry
            foreach (var player in players)
            {
                if (player == player1)
                {
                    Console.WriteLine("\nRzuć kością.");
                    Console.ReadLine();
                }
                int move = random.Next(7); // "rzut kością"
                player.Movement(move, true); // ruch gracza po planszy

                Thread.Sleep(1500);
                
                // Gdy dwaj gracze spotkają się na jednym polu, jest walka
                if (player.GetType() == typeof(Warrior))
                {
                    var matchingPlayer = players.Find(player2 =>
                        player.Position == player2.Position && player.Name != player2.Name);
                    if (matchingPlayer != null)
                        player.(matchingPlayer);
                }
                //var matchingPlayer = players.Find(player2 => player.Position == player2.Position && player.Name != player2.Name);
                //if (matchingPlayer != null && matchingPlayer.GetType() == typeof(Warrior)) player.Attack(matchingPlayer);
                
                Thread.Sleep(1500);
                
                Game.PrizeSpace(player, board); // sprawdzanie, czy gracz jest na polu specjalnym
                
                Thread.Sleep(1000);
            }
            numberOfTurns++;
        }
        
        // Zakończenie gry
        Game.Finish(players, numberOfTurns);
    }
}