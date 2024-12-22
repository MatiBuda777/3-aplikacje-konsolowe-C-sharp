namespace DefaultNamespace;

public class BookingSystem
{
    private List<Concert> concerts=new List<Concert>()
    private List<Ticket> tickets = new List<Ticket>()


    public void AddConcert(Concert concert)
    {
        concerts.Add(concert);
    }

    public void DisplayConcerts()
    {
        foreach (var concert in concerts)
        {
            Console.WriteLine(
                $"Koncert: {concert.Name}, Data: {concert.Date}, Lokalizacja: {concert.Location}, Miejsca: {concert.AvailableSeats}");
        }
    }

    public void BookTickets(string concertName, double price)
    {
        var concert = concerts.FirtsDefault(c => c.Name==concertName);

        if (concert != null && concert.AviableSeats > 0)
        {
            int seatNumber = concert.AviableSeats;
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