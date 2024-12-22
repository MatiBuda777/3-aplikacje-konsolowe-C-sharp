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
        var concert =
    }
}