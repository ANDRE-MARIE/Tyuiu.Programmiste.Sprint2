
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

            // Test quand x * 10 > y + 2
            // x=2, y=1 → 2*10=20 > 1+2=3 → condition vraie
            double result = ds.Calculate(2, 1);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void CalculateWhenConditionFalse()
        {
            DataService ds = new DataService();

            // Test quand x * 10 <= y + 2  
            // x=1, y=20 → 1*10=10 <= 20+2=22 → condition fausse
            double result = ds.Calculate(1, 20);
            Assert.AreEqual(398, result);
        }

        [TestMethod]
        public void CalculateWithDecimalValues()
        {
            DataService ds = new DataService();

            // Test avec valeurs décimales
            double result = ds.Calculate(3.5, 2.1);
            Assert.AreEqual(15.309, result);
        }

        [TestMethod]
        public void CalculateRounding()
        {
            DataService ds = new DataService();

            // Vérification de l'arrondi à 3 décimales
            double result = ds.Calculate(2.123, 3.456);
            double expected = Math.Round(2.123 * Math.Pow((3.456 + 2) / (2.123 - 1), 2.123), 3);
            Assert.AreEqual(expected, result);
        }
    }
}
    
