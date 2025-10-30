
using Tyuiu.Programmiste.Sprint2.Task4.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("Calcul de la valeur Z avec opérateur ternaire");
        Console.WriteLine("=============================================");
        Console.WriteLine("Condition : si x * 10 > y + 2");
        Console.WriteLine("Alors : z = x * ((y + 2) / (x - 1))^x");
        Console.WriteLine("Sinon : z = y² - (2 / x)");
        Console.WriteLine("=============================================");

        

        Console.Write("Entrez x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Entrez y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        // APPEL DIRECT SANS MODIFICATION
        double result = ds.Calculate(x, y);

        Console.WriteLine($"Result: {result}");
        Console.ReadKey();
    }
}

