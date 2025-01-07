// See https://aka.ms/new-console-template for more information

internal class Program
{
    // Metoda do pisania linii
    public static Action<char, int> Line = (char type, int num) => Console.WriteLine(string.Concat(Enumerable.Repeat(type, num))); 
            
    public static void Main(string[] args)
    {
        // Console.ForegroundColor();
        while (true)
        {
            Program.Line('=', 25);
            Console.Write(" Sports Team Management System ");
            Program.Line('=', 25);
            
            
        }
        
    }
}