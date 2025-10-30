
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

        try
        {
            Console.Write("Entrez la valeur de x : ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez la valeur de y : ");
            double y = Convert.ToDouble(Console.ReadLine());

            // Vérification des divisions par zéro
            if (x == 1 && x * 10 > y + 2)
            {
                Console.WriteLine("Erreur : Division par zéro (x - 1 = 0)");
            }
            else if (x == 0 && x * 10 <= y + 2)
            {
                Console.WriteLine("Erreur : Division par zéro (x = 0)");
            }
            else
            {
                double result = ds.Calculate(x, y);
                Console.WriteLine($"\nRésultat : z = {result}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Erreur : Veuillez entrer des nombres valides.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur : {ex.Message}");
        }

        Console.WriteLine("\nAppuyez sur une touche pour quitter...");
        Console.ReadKey();
    }
}
