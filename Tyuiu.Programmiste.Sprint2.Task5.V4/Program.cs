
using Tyuiu.Programmiste.Sprint2.Task5.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("CARD SUIT DETERMINATION");
        Console.WriteLine("=======================");
        Console.WriteLine("Suit coding:");
        Console.WriteLine("1 - Spades");
        Console.WriteLine("2 - Clubs");
        Console.WriteLine("3 - Diamonds");
        Console.WriteLine("4 - Hearts");
        Console.WriteLine("=======================");

        try
        {
            Console.Write("Enter suit number (1-4) : ");
            int colorNumber = Convert.ToInt32(Console.ReadLine());

            string result = ds.FindCardSuit(colorNumber);
            Console.WriteLine($"\nResult: {result}");

            if (result == "unknown suit")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Number must be between 1 and 4");
                Console.ResetColor();
            }
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Please enter a valid integer.");
            Console.ResetColor();
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

