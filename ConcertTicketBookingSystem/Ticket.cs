namespace DefaultNamespace;

public class Ticket
{
    public Concert Concert { get; set; }
    public int SeatNumber { get; set; }
    public decimal Price { get; set; }
    
    //konstruktor
    public Ticket(this.concert, int SeatNumber, decimal Price)
    {
        Concert = Concert;
        Price = Price;
        SeatNumber = SeatNumber;
    }
    
}