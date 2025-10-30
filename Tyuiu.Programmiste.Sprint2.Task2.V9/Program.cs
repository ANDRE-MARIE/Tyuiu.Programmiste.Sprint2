
using Tyuiu.Programmiste.Sprint2.Task2.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        
        {
            Console.Title = "Sprint 2 - Vérification de point dans une zone";
            Console.ForegroundColor = ConsoleColor.Cyan;

            DataService ds = new DataService();

            Console.WriteLine("================================================");
            Console.WriteLine(" VÉRIFICATION DE POINT DANS ZONE OMBRÉE");
            Console.WriteLine("================================================");
            Console.ResetColor();

            Console.WriteLine("Zone ombrée : Triangle (0,0)-(15,0)-(0,15) + Rectangle (5,3)-(10,8)");
            Console.WriteLine();

            try
            {
                // Saisie des coordonnées
                Console.Write("Entrez la coordonnée X (0-15) : ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Entrez la coordonnée Y (0-15) : ");
                int y = Convert.ToInt32(Console.ReadLine());

                // Vérification
                bool isInArea = ds.CheckDotInShadedArea(x, y);

                // Affichage du résultat
                Console.WriteLine();
                Console.ForegroundColor = isInArea ? ConsoleColor.Green : ConsoleColor.Red;
                Console.WriteLine($"Point ({x},{y}) : {(isInArea ? "DANS la zone ombrée" : "HORS de la zone ombrée")}");
                Console.ResetColor();

                // Affichage visuel
                DisplayGrid(x, y, isInArea);
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erreur : Veuillez entrer des nombres entiers valides.");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Erreur : {ex.Message}");
                Console.ResetColor();
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Appuyez sur une touche pour quitter...");
            Console.ResetColor();
            Console.ReadKey();
        }

        static void DisplayGrid(int userX, int userY, bool isInArea)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Représentation graphique (15x15) :");
            Console.ResetColor();

            // En-tête avec numéros de colonnes
            Console.Write("   ");
            for (int x = 0; x <= 15; x++)
            {
                Console.Write($"{x:D2} ");
            }
            Console.WriteLine();

            // Grille
            for (int y = 15; y >= 0; y--)
            {
                Console.Write($"{y:D2} ");
                for (int x = 0; x <= 15; x++)
                {
                    if (x == userX && y == userY)
                    {
                        Console.ForegroundColor = isInArea ? ConsoleColor.Green : ConsoleColor.Red;
                        Console.Write(" ");
                        Console.ResetColor();
                    }
                    else if ((x >= 0 && y >= 0 && x + y <= 15) || (x >= 5 && x <= 10 && y >= 3 && y <= 8))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("·  ");
                    }
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Légende : =Votre point, =Zone ombrée, ·=Zone vide");
            Console.ResetColor();
        }
    }
}