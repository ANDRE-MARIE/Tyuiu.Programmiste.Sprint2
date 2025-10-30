
using Tyuiu.Programmiste.Sprint2.Task7.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #0 / выполнил: И. С. / ПКТБ25-1";
        //Длинна строки 75 сиволов
        Console.WriteLine("*******************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                               *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                                             *");
        Console.WriteLine("* Задания #7                                                                              *");
        Console.WriteLine("* Вариант #5                                                                              *");
        Console.WriteLine("* выполнил: И. С. / ПКТБ25-1                                                              *");
        Console.WriteLine("*******************************************************************************************");
        Console.WriteLine("* Условие:                                                                                *");
        Console.WriteLine("*                                                                                         *");
        Console.WriteLine("*                                                                                         *");
        Console.WriteLine("*                                                                                         *");
        Console.WriteLine("*******************************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
        Console.WriteLine("*******************************************************************************************");
        Console.WriteLine("VÉRIFICATION DE POINT DANS LA ZONE OMBRÉE                                            ");
        Console.WriteLine("======================================================================================");
        Console.WriteLine("Zone ombrée définie par :");
        Console.WriteLine("- Courbe inférieure : y = x²");
        Console.WriteLine("- Courbe supérieure : y = e^x");
        Console.WriteLine("- Pour x ≥ 0");
        Console.WriteLine("=======================================================================================");

        try
        {
            Console.Write("Entrez la coordonnée X : ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez la coordonnée Y : ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine();
            Console.ForegroundColor = result ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine($"Point ({x:F2}, {y:F2}) : {(result ? "DANS la zone ombrée" : "HORS de la zone ombrée")}");
            Console.ResetColor();

            // Affichage des valeurs des courbes pour référence
            if (x >= 0)
            {
                double lowerBound = Math.Pow(x, 2);
                double upperBound = Math.Exp(x);

                Console.WriteLine($"\nPour X = {x:F2} :");
                Console.WriteLine($"- y = x² = {lowerBound:F2}");
                Console.WriteLine($"- y = e^x = {upperBound:F2}");
                Console.WriteLine($"- Votre Y = {y:F2}");
            }
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erreur : Veuillez entrer des nombres valides.");
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
