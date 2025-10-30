using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.Programmiste.Sprint2.Task6.V1.Lib
{
    public class DataService : ISprint2Task6V1
    {
        public int FindMonthDaysCount(int value)
        {
            int daysCount = value switch
            {
                1 => 31,  // Janvier
                2 => 28,  // Février (non bissextile)
                3 => 31,  // Mars
                4 => 30,  // Avril
                5 => 31,  // Mai
                6 => 30,  // Juin
                7 => 31,  // Juillet
                8 => 31,  // Août
                9 => 30,  // Septembre
                10 => 31, // Octobre
                11 => 30, // Novembre
                12 => 31, // Décembre
                _ => -1   // Mois invalide
            };

            return daysCount;
        }
    }
}
        
