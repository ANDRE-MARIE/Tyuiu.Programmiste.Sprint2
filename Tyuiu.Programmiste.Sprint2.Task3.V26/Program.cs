
using Tyuiu.Programmiste.Sprint2.Task3.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("Calcul de la fonction Y(X)");
        Console.WriteLine("===========================");

        try
        {
            Console.Write("Entrez X : ");
            double x = Convert.ToDouble(Console.ReadLine());

            double result = ds.Calculate(x);

            if (double.IsNaN(result))
                Console.WriteLine("Calcul impossible pour cette valeur de X");
            else
                Console.WriteLine($"Y({x}) = {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur : {ex.Message}");
        }

        Console.ReadKey();
    }
}
