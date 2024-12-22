using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Concert> concerts = new List<Concert>()
        {
            new Concert("Rock Night", new DateTime(2024, 5, 20), "Warsaw", 100),
            new Concert("Jazz Fest", new DateTime(2024, 6, 15), "Krakow", 50),
            new Concert("Pop Extravaganza", new DateTime(2024, 7, 30), "Gdansk", 150)
        };

        while (true)
        {
            Console.WriteLine("\nWybierz opcję:");
            Console.WriteLine("1 - Dodaj nowy koncert");
            Console.WriteLine("2 - Przeglądaj koncerty");
            Console.WriteLine("3 - Rezerwuj bilet");
            Console.WriteLine("4 - Wyjście");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddNewConcert(concerts);
                    break;
                case 2:
                    ShowConcerts(concerts);
                    break;
                case 3:
                    ReserveTicket(concerts);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;
            }
        }
    }

    static void AddNewConcert(List<Concert> concerts)
    {
        Console.WriteLine("\nDodaj nowy koncert:");
        Console.WriteLine("Podaj nazwę koncertu:");
        string name = Console.ReadLine();

        Console.WriteLine("Podaj datę koncertu (format: yyyy-MM-dd):");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Podaj lokalizację koncertu:");
        string location = Console.ReadLine();

        Console.WriteLine("Podaj liczbę dostępnych miejsc:");
        int availableSeats = int.Parse(Console.ReadLine());

        Concert newConcert = new Concert(name, date, location, availableSeats);
        concerts.Add(newConcert);

        Console.WriteLine("Koncert dodany.");
    }

    static void ShowConcerts(List<Concert> concerts)
    {
        Console.WriteLine("\nLista koncertów:");
        foreach (var concert in concerts)
        {
            Console.WriteLine($"{concert.Name} - {concert.Date.ToShortDateString()} - {concert.Location} - {concert.AvailableSeats} miejsc");
        }
    }

    static void ReserveTicket(List<Concert> concerts)
    {
        Console.WriteLine("\nRezerwacja biletu na koncert:");
        Console.WriteLine("Podaj nazwę koncertu, na który chcesz zarezerwować bilet:");
        string selectedConcertName = Console.ReadLine();

        Console.WriteLine("Podaj numer miejsca:");
        int seatNumber = int.Parse(Console.ReadLine());

        Concert selectedConcert = concerts.Find(c => c.Name.Equals(selectedConcertName, StringComparison.OrdinalIgnoreCase));

        if (selectedConcert != null)
        {
            if (selectedConcert.AvailableSeats > 0)
            {
                Ticket ticket = new Ticket(selectedConcert, seatNumber, 100); // Domyślna cena biletu
                selectedConcert.AvailableSeats--; // Zmniejszenie liczby dostępnych miejsc
                Console.WriteLine($"Zarezerwowano bilet na koncert {ticket.Concert.Name} na miejsce {ticket.SeatNumber}.");
            }
            else
            {
                Console.WriteLine("Brak dostępnych miejsc na ten koncert.");
            }
        }
        else
        {
            Console.WriteLine("Nie znaleziono takiego koncertu.");
        }
    }
}