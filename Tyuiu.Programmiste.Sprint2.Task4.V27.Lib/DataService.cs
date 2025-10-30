
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
                // z = x * ((y + 2) / (x - 1))^x
                if (Math.Abs(x - 1) < 0.000001)
                    return 0;

                double baseValue = (y + 2) / (x - 1);
                result = x * Math.Pow(baseValue, x);
            }
            else
            {
                // z = y² - (2 / x)
                if (Math.Abs(x) < 0.000001)
                    return 0;

                result = (y * y) - (2 / x);
            }

            // ARRONDI DANS LA BIBLIOTHÈQUE SEULEMENT
            return Math.Round(result, 3);
        }
    }
}



