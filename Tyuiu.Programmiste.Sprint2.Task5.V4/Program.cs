
using Tyuiu.Programmiste.Sprint2.Task5.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("DÉTERMINATION DES COULEURS DE CARTES À JOUER");
        Console.WriteLine("=============================================");
        Console.WriteLine("Codage des couleurs :");
        Console.WriteLine("1 - Piques");
        Console.WriteLine("2 - Trèfles");
        Console.WriteLine("3 - Carreaux");
        Console.WriteLine("4 - Cœurs");
        Console.WriteLine("=============================================");

        try
        {
            Console.Write("Entrez le numéro de couleur (1-4) : ");
            int colorNumber = Convert.ToInt32(Console.ReadLine());

            string result = ds.FindCardSuit(colorNumber);

            Console.WriteLine($"\nRésultat : {result}");

            if (result == "couleur inconnue")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erreur : Le numéro doit être entre 1 et 4");
                Console.ResetColor();
            }
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erreur : Veuillez entrer un nombre entier valide.");
            Console.ResetColor();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Erreur : {ex.Message}");
            Console.ResetColor();
        }

        Console.WriteLine("\nAppuyez sur une touche pour quitter...");
        Console.ReadKey();
    }
}
