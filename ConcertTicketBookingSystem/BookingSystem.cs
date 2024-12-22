using System;
using System.Collections.Generic;
using System.Linq;

public class BookingSystem
{
    private List<Concert> concerts = new List<Concert>();
    private List<Ticket> tickets = new List<Ticket>();


    public void AddConcert(string name, DateTime date, string location, int availableSeats)
    {
        concerts.Add(new Concert(name, date, location, availableSeats)); // Użycie konstruktora
    }


    public void DisplayConcerts()
    {
        foreach (var concert in concerts)
        {
            Console.WriteLine(
                $"Koncert: {concert.Name}, Data: {concert.Date}, Lokalizacja: {concert.Location}, Miejsca: {concert.AvailableSeats}");
        }
    }

    public void BookTickets(string concertName, int price)
    {
        var concert = concerts.FirstOrDefault(c => c.Name==concertName);

        if (concert != null && concert.AvailableSeats > 0)
        {
            int seatNumber = concert.AvailableSeats;
            concert.ReserveSeat();
            Ticket ticket = new Ticket(concert, price, seatNumber);
            tickets.Add(ticket);

            Console.WriteLine("Zarazerwowano bilet");
            Console.WriteLine(ticket);
        }
        else
        {
            Console.WriteLine("Nie mozna zarezerwować biletu");
        }
    }

    public void GenerateReport()
    {
        Console.WriteLine("Raport sprzedanych biletów: ");
        foreach (var ticket in tickets)
        {
            Console.WriteLine(ticket);
        }
    }
}