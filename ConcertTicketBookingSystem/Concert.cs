public class Concert{
    public string Name{get;set;}
    public DateTime Date{get;set;}
    public string Location{get;set;}
    public int AvailableSeats{get;set;}

    public Concert(string name, DateTime date, string location, int availableSeats)
    {
        Name = name;
        Date = date;
        Location = location;
        AvailableSeats = availableSeats;
    }

    public void ReserveSeat()
    {
        if (AvailableSeats > 0)
        {
            AvailableSeats--;
        }
        else
        {
            Console.WriteLine("Brak dostępnych miejsc ");
        }
    }
}