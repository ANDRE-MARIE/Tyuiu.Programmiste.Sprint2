
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Programmiste.Sprint2.Task4.V27.Lib
{
    public class DataService : ISprint2Task4V27
    {
        public double Calculate(double x, double y)
        {
            double result = (x * 10 > y + 2)
                ? x * Math.Pow((y + 2) / (x - 1), x)
                : Math.Pow(y, 2) - (2 / x);

            return Math.Round(result, 3);
        }
    }
}
    
