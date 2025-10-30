using Tyuiu.Programmiste.Sprint2.Task5.V4.Lib;

namespace Tyuiu.Programmiste.Sprint2.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FindCardSuitValidPiques()
        {
            DataService ds = new DataService();
            string result = ds.FindCardSuit(1);
            Assert.AreEqual("piques", result);
        }

        [TestMethod]
        public void FindCardSuitValidTrefles()
        {
            DataService ds = new DataService();
            string result = ds.FindCardSuit(2);
            Assert.AreEqual("trèfles", result);
        }

        [TestMethod]
        public void FindCardSuitValidCarreaux()
        {
            DataService ds = new DataService();
            string result = ds.FindCardSuit(3);
            Assert.AreEqual("carreaux", result);
        }

        [TestMethod]
        public void FindCardSuitValidCoeurs()
        {
            DataService ds = new DataService();
            string result = ds.FindCardSuit(4);
            Assert.AreEqual("cœurs", result);
        }

        [TestMethod]
        public void FindCardSuitInvalidNumber()
        {
            DataService ds = new DataService();

            Assert.AreEqual("couleur inconnue", ds.FindCardSuit(0));
            Assert.AreEqual("couleur inconnue", ds.FindCardSuit(5));
            Assert.AreEqual("couleur inconnue", ds.FindCardSuit(-1));
            Assert.AreEqual("couleur inconnue", ds.FindCardSuit(100));
        }

        [TestMethod]
        public void FindCardSuitBoundaryValues()
        {
            DataService ds = new DataService();

            // Test des limites valides
            Assert.AreEqual("piques", ds.FindCardSuit(1));
            Assert.AreEqual("cœurs", ds.FindCardSuit(4));

            // Test des limites invalides
            Assert.AreEqual("couleur inconnue", ds.FindCardSuit(0));
            Assert.AreEqual("couleur inconnue", ds.FindCardSuit(5));
        }
    }
}