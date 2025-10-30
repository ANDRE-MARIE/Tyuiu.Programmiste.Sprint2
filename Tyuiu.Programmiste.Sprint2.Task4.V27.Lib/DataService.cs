
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Programmiste.Sprint2.Task4.V27.Lib
{
    public class DataService : ISprint2Task4V27
    {
        public double Calculate(double x, double y)
        {
            double result;

            if (x * 10 > y + 2)
            {
                // Condition : x * 10 > y + 2
                // Formule : z = x * ((y + 2) / (x - 1))^x

                // Vérification sécurité
                if (x == 1) return 0;

                double baseValue = (y + 2) / (x - 1);
                result = x * Math.Pow(baseValue, x);
            }
            else
            {
                // Condition : x * 10 <= y + 2  
                // Formule : z = y² - (2 / x)

                // Vérification sécurité
                if (x == 0) return 0;

                result = (y * y) - (2 / x);
            }

            return Math.Round(result, 3);
        }
    }
}




