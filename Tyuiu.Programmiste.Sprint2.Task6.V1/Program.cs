
using Tyuiu.Programmiste.Sprint2.Task6.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("DÉTERMINATION DU NOMBRE DE JOURS DANS UN MOIS");
        Console.WriteLine("==============================================");
        Console.WriteLine("Codage des mois :");
        Console.WriteLine("1 - Janvier");
        Console.WriteLine("2 - Février");
        Console.WriteLine("3 - Mars");
        Console.WriteLine("4 - Avril");
        Console.WriteLine("5 - Mai");
        Console.WriteLine("6 - Juin");
        Console.WriteLine("7 - Juillet");
        Console.WriteLine("8 - Août");
        Console.WriteLine("9 - Septembre");
        Console.WriteLine("10 - Octobre");
        Console.WriteLine("11 - Novembre");
        Console.WriteLine("12 - Décembre");
        Console.WriteLine("==============================================");

        try
        {
            Console.Write("Entrez le numéro du mois (1-12) : ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            int result = ds.FindMonthDaysCount(monthNumber);

            if (result == -1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erreur : Le numéro doit être entre 1 et 12");
                Console.ResetColor();
            }
            else
            {
                string monthName = GetMonthName(monthNumber);
                Console.WriteLine($"\nLe mois de {monthName} a {result} jours");
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

    private static string GetMonthName(int month)
    {
        return month switch
        {
            1 => "Janvier",
            2 => "Février",
            3 => "Mars",
            4 => "Avril",
            5 => "Mai",
            6 => "Juin",
            7 => "Juillet",
            8 => "Août",
            9 => "Septembre",
            10 => "Octobre",
            11 => "Novembre",
            12 => "Décembre",
            _ => "Inconnu"
        };
    }
}
