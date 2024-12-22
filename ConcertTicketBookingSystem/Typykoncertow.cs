
public interface IConcertType
{
    string GetConcerType();
}

public class VIPConcert : Concert, IConcertType
{
    public VIPConcert(string name, DateTime date, string location, int availableSeats):base(name, date, location, availableSeats){}

    public string GetConcertType()
    {
        return"VIP Concert";
    }
}

public class OnlineConcert : Concert, IConcertType
{
    public OnlineConcert(string name, DateTime date, string location, int availableSeats):base(name, date, location, availableSeats){}

    public string GetConcertType()
    {
        return"Online Concert";
    }
}