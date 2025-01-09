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
        Console.WriteLine("Podaj swoje imię:");
        string mngName = Console.ReadLine();
        Console.WriteLine($"Witaj, Menedżerze {mngName}!");
        Line('=', 60);
        Thread.Sleep(1000);
        
        Team team = new();
        
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine(); 
            Line('=', 25);
            Console.Write(" Sports Team Management System ");
            Line('=', 25);
            
            // -- Menu wyboru
            Console.WriteLine("Wybierz, co chcesz zrobić:");
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
                    Console.WriteLine("Dodawanie zawodnika do drużyny...");
                    team.Add();
                    break;

                case "2":
                    Line('=', 50);
                    Console.WriteLine("Usuwanie zawodnika z drużyny...");
                    team.Remove();
                    break;

                case "3":
                    Line('=', 50);
                    Console.WriteLine("Aktualizacja wyniku zawodnika...");
                    team.Search(1);
                    break;

                case "4":
                    Line('=', 50);
                    Console.WriteLine("Wyświetlanie statystyk drużyny...");
                    team.Stats();
                    break;

                case "5":
                    Line('=', 50);
                    Console.WriteLine("Obliczanie średniej punktów drużyny...");
                    Console.WriteLine("Średnia drużyny to " + Team.AvgScore(team.Players) + " goli.");
                    break;

                case "6":
                    Line('=', 50);
                    Console.WriteLine("Wyszukiwanie zawodników według pozycji...");
                    team.Search(2);
                    break;

                case "7":
                    Line('=', 50);
                    Console.WriteLine("Filtracja zawodników na podstawie kryteriów...");
                    // Tutaj dodaj logikę filtrowania zawodników
                    break;

                case "8":
                    exit = true;
                    Line('=', 50);
                    Console.WriteLine("Zamykanie programu...");
                    break;

                default:
                    Line('=', 50);
                    Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                    break;
            }
        }
    }
}