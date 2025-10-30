
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Programmiste.Sprint2.Task4.V27.Lib
{
    public class DataService : ISprint2Task4V27
    {
        public double Calculate(double x, double y)
        {
            if (x * 10 > y + 2)
            {
                if (Math.Abs(x - 1) < 0.0001) // Éviter division par zéro
                    return 0;

                return Math.Round(x * Math.Pow((y + 2) / (x - 1), x), 3);
            }
            else
            {
                if (Math.Abs(x) < 0.0001) // Éviter division par zéro
                    return 0;

                return Math.Round(Math.Pow(y, 2) - (2 / x), 3);
            }
        }
    }
}




