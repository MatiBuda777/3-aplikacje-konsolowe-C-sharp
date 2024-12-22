

public class Ticket
{
    public Concert Concert { get; set; }
    public int SeatNumber { get; set; }
    public decimal Price { get; set; }
    
    
    //konstruktor
    public Ticket(Concert concert, int seatNumber, decimal price)
    {
        Concert = concert;
        Price = price;
        SeatNumber = seatNumber;
    }

    public override string ToString()
    {
        return $"Koncert: {Concert.Name}, Data: {Concert.Date}, Miejsce: {SeatNumber}, Cena: {Price}";
    }
}
