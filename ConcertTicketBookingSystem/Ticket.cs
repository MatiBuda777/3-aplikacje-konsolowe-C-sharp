

public class Ticket
{
    public Concert Concert { get; set; }
    public int SeatNumber { get; set; }
    public decimal Price { get; set; }
    
    //konstruktor
    public Ticket(Concert concert, int SeatNumber, decimal Price)
    {
        Concert = Concert;
        Price = Price;
        SeatNumber = SeatNumber;
    }

    public override string ToString()
    {
        return $"Koncert: {Concert.Name}, Data: {Concert.Date}, Miejsce: {SeatNumber}, Cena: {Price}";
    }
}
