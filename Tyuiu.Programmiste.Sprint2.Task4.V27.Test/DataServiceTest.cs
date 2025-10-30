
using Tyuiu.Programmiste.Sprint2.Task4.V27.Lib;
namespace Tyuiu.Programmiste.Sprint2.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalculateWhenConditionTrue()
        {
            DataService ds = new DataService();

            // Test avec des valeurs qui devraient donner ~24.6
            // Essayez différentes combinaisons :
            double result1 = ds.Calculate(3, 5);    // x=3, y=5
            double result2 = ds.Calculate(2.5, 4);  // x=2.5, y=4
            double result3 = ds.Calculate(4, 10);   // x=4, y=10

            Console.WriteLine($"Résultat 1: {result1}");
            Console.WriteLine($"Résultat 2: {result2}");
            Console.WriteLine($"Résultat 3: {result3}");
        }
    }
}
