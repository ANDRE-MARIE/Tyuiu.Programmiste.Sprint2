
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Programmiste.Sprint2.Task3.V26.Lib
{
    public class DataService : ISprint2Task3V26
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 0)
            {
                double cosX2 = Math.Cos(x * x);
                if (Math.Abs(cosX2) < 0.0001) return double.NaN;

                double fraction = (x + 1) / cosX2;
                double power = Math.Pow(fraction, x);
                y = x + power;
            }
            else if (x == 0)
            {
                double numerator = 15 + x;
                double sinX2 = Math.Sin(x * x);
                double denominator = 9 - sinX2;

                if (Math.Abs(denominator) < 0.0001) return double.NaN;
                y = numerator / denominator;
            }
            else if (x > -30 && x < 0)
            {
                double sinX3 = Math.Sin(x * x * x);
                double denominator = x + 5;

                if (Math.Abs(denominator) < 0.0001) return double.NaN;
                if (sinX3 / denominator <= 0) return double.NaN;

                y = Math.Pow(sinX3 / denominator, x);
            }
            else if (x < -30)
            {
                if (Math.Abs(x) < 0.0001) return double.NaN;
                y = 8 * x - (1 / x);
            }

            return Math.Round(y, 3);
        }
    }
}
