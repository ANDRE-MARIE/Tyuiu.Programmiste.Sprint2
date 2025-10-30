
using Tyuiu.Programmiste.Sprint2.Task7.V5.Lib;
namespace Tyuiu.Programmiste.Sprint2.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedAreaValid()
        {
            DataService ds = new DataService();

            // Points dans la zone ombrée
            Assert.IsTrue(ds.CheckDotInShadedArea(0, 0.5));    // Entre 0 et 1 à x=0
            Assert.IsTrue(ds.CheckDotInShadedArea(1, 1.5));    // Entre 1 et e à x=1
            Assert.IsTrue(ds.CheckDotInShadedArea(0.5, 0.5));  // Au milieu
        }

        [TestMethod]
        public void CheckDotInShadedAreaOnBoundary()
        {
            DataService ds = new DataService();

            // Points sur les frontières
            Assert.IsTrue(ds.CheckDotInShadedArea(0, 0));      // Sur y = x²
            Assert.IsTrue(ds.CheckDotInShadedArea(1, 1));      // Sur y = x²
            Assert.IsTrue(ds.CheckDotInShadedArea(0, 1));      // Sur y = e^x
            Assert.IsTrue(ds.CheckDotInShadedArea(1, Math.Exp(1))); // Sur y = e^x
        }

        [TestMethod]
        public void CheckDotInShadedAreaOutside()
        {
            DataService ds = new DataService();

            // Points en dehors de la zone
            Assert.IsFalse(ds.CheckDotInShadedArea(-1, 0.5));  // x négatif
            Assert.IsFalse(ds.CheckDotInShadedArea(1, 0.5));   // En dessous de x²
            Assert.IsFalse(ds.CheckDotInShadedArea(1, 3.5));   // Au-dessus de e^x
            Assert.IsFalse(ds.CheckDotInShadedArea(2, 10));    // Loin au-dessus
        }

        [TestMethod]
        public void CheckDotInShadedAreaEdgeCases()
        {
            DataService ds = new DataService();

            // Cas limites
            Assert.IsTrue(ds.CheckDotInShadedArea(0.1, 0.02));  // Proche de l'origine
            Assert.IsFalse(ds.CheckDotInShadedArea(0.1, 0.005)); // Trop bas
            Assert.IsTrue(ds.CheckDotInShadedArea(2, 5));       // Dans la zone à x=2
        }

        [TestMethod]
        public void CheckDotInShadedAreaPrecision()
        {
            DataService ds = new DataService();

            // Test de précision avec des valeurs décimales
            Assert.IsTrue(ds.CheckDotInShadedArea(0.5, 0.3));
            Assert.IsFalse(ds.CheckDotInShadedArea(0.5, 0.2));
            Assert.IsTrue(ds.CheckDotInShadedArea(1.5, 3.0));
        }
    }
}