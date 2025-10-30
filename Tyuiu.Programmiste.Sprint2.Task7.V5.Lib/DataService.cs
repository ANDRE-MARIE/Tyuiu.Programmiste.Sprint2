
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.Programmiste.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // La zone ombrée est entre y = x² (en bas) et y = e^x (en haut)
            // Pour x >= 0

            if (x < 0)
            {
                return false; // La zone ombrée commence à x = 0
            }

            double lowerBound = Math.Pow(x, 2);   // y = x²
            double upperBound = Math.Exp(x);      // y = e^x

            // Le point est dans la zone ombrée si y est entre x² et e^x
            return (y >= lowerBound) && (y <= upperBound);
        }
    }
}
    
