
using Tyuiu.Programmiste.Sprint2.Task3.V26.Lib;
namespace Tyuiu.Programmiste.Sprint2.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalculateValid()
        {
            DataService ds = new DataService();

            // Test avec différentes valeurs
            Assert.AreEqual(1.667, ds.Calculate(0));
            // Ajoutez d'autres tests selon votre fonction
        }
    }
}
    
