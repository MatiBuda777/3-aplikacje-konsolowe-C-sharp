// See https://aka.ms/new-console-template for more information

using Sports_Team_Manager_System;

internal class Program
{
    // Metoda do pisania linii
    public static Action<char, int> Line = (char type, int num) => Console.Write(string.Concat(Enumerable.Repeat(type, num)));
    
    public static void Main(string[] args)
    {
        Line('=', 25);
        Console.Write(" Sports Team Management System ");
        Line('=', 25);
        
        // Wprowadź imię menadżera
        Console.WriteLine("\nPodaj swoje imię:");
        string mngName = Console.ReadLine();
        Console.WriteLine($"Witaj, Menedżerze {mngName}!");
        
        Team team = new();
        
        // gracze startowi
        team.AddPlayer(new Player(50, "Robert Lewandowski", "Napastnik"));
        team.AddPlayer(new Player(34, "Krzysztof Piątek", "Napastnik"));
        team.AddPlayer(new Player(21, "Zbigniew Boniek", "Pomocnik"));
        team.AddPlayer(new Player(22, "Jakub Błaszczykowski", "Pomocnik"));
        team.AddPlayer(new Player(5, "Paweł Olkowski", "Obrońca"));
        team.AddPlayer(new Player("Łukasz Fabiański", "Bramkarz"));
        team.AddPlayer(new Player(2, "Kamil Glik", "Obrońca"));
        
        bool exit = false;
        while (!exit)
        {
            Thread.Sleep(2000);
            Console.WriteLine(); 
            Line('=', 25);
            Console.Write(" Sports Team Management System ");
            Line('=', 25);
            Thread.Sleep(500);
            
            // -- Menu wyboru
            Console.WriteLine("\nWybierz, co chcesz zrobić:");
            Console.WriteLine("1 - Dodaj zawodnika do drużyny");
            Console.WriteLine("2 - Usuń zawodnika z drużyny");
            Console.WriteLine("3 - Zaktualizuj wynik zawodnika");
            Console.WriteLine("4 - Wyświetl statystyki drużyny");
            Console.WriteLine("5 - Oblicz średnią punktów drużyny");
            Console.WriteLine("6 - Wyszukaj zawodników według pozycji");
            Console.WriteLine("7 - Filtruj zawodników na podstawie kryteriów");
            Console.WriteLine("8 - Wyjście");
            // ---------------
            
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Line('=', 50);
                    Console.WriteLine("\nDodawanie zawodnika do drużyny...");
                    team.Add();
                    break;

                case "2":
                    Line('=', 50);
                    Console.WriteLine("\nUsuwanie zawodnika z drużyny...");
                    team.Remove();
                    break;

                case "3":
                    Line('=', 50);
                    Console.WriteLine("\nAktualizacja wyniku zawodnika...");
                    team.Search(1);
                    break;

                case "4":
                    Line('=', 50);
                    Console.WriteLine("\nWyświetlanie statystyk drużyny...");
                    team.Stats();
                    break;

                case "5":
                    Line('=', 50);
                    Console.WriteLine("\nObliczanie średniej punktów drużyny...");
                    Console.WriteLine("Średnia drużyny to " + Team.AvgScore(team.Players) + " goli.");
                    break;

                case "6":
                    Line('=', 50);
                    Console.WriteLine("\nWyszukiwanie zawodników według pozycji...");
                    team.Search(2);
                    break;

                case "7":
                    Line('=', 50);
                    Console.WriteLine("\nFiltracja zawodników na podstawie kryteriów...");
                    team.Filter();
                    break;

                case "8":
                    exit = true;
                    Line('=', 50);
                    Console.WriteLine("\nZamykanie programu...");
                    break;

                default:
                    Line('=', 50);
                    Console.WriteLine("\nNieprawidłowy wybór. Spróbuj ponownie.");
                    break;
            }
        }
    }
}