
using System.Data;
using System.Net.Sockets;

class Program 
{
    static void Main(string[] args) 
    {
        List<Concert> concerts = new List<Concert>();

        // Wprowadzenie danych koncertu
        Console.WriteLine("Podaj nazwę koncertu:");
        string name = Console.ReadLine();

        Console.WriteLine("Podaj datę koncertu (dd/MM/yyyy):");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Podaj lokalizację koncertu:");
        string location = Console.ReadLine();

        Console.WriteLine("Podaj liczbę dostępnych miejsc:");
        int availableSeats = int.Parse(Console.ReadLine());
        
        concerts.Add(new Concert(name, date, location, availableSeats));
        
        Console.WriteLine("\nDostępne koncerty:");
        foreach (var concert in concerts)
        {
            Console.WriteLine($"Nazwa: {concert.Name}, Data: {concert.Date.ToShortDateString()}, Lokalizacja: {concert.Location}, Miejsca: {concert.AvailableSeats}");
        }

      
    }
}