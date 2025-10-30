
using Tyuiu.Programmiste.Sprint2.Task6.V1.Lib;
namespace Tyuiu.Programmiste.Sprint2.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FindMonthDaysCount31Days()
        {
            DataService ds = new DataService();

            // Mois avec 31 jours
            Assert.AreEqual(31, ds.FindMonthDaysCount(1));  // Janvier
            Assert.AreEqual(31, ds.FindMonthDaysCount(3));  // Mars
            Assert.AreEqual(31, ds.FindMonthDaysCount(5));  // Mai
            Assert.AreEqual(31, ds.FindMonthDaysCount(7));  // Juillet
            Assert.AreEqual(31, ds.FindMonthDaysCount(8));  // Août
            Assert.AreEqual(31, ds.FindMonthDaysCount(10)); // Octobre
            Assert.AreEqual(31, ds.FindMonthDaysCount(12)); // Décembre
        }

        [TestMethod]
        public void FindMonthDaysCount30Days()
        {
            DataService ds = new DataService();

            // Mois avec 30 jours
            Assert.AreEqual(30, ds.FindMonthDaysCount(4));  // Avril
            Assert.AreEqual(30, ds.FindMonthDaysCount(6));  // Juin
            Assert.AreEqual(30, ds.FindMonthDaysCount(9));  // Septembre
            Assert.AreEqual(30, ds.FindMonthDaysCount(11)); // Novembre
        }

        [TestMethod]
        public void FindMonthDaysCountFebruary()
        {
            DataService ds = new DataService();

            // Février (28 jours - année non bissextile)
            Assert.AreEqual(28, ds.FindMonthDaysCount(2));
        }

        [TestMethod]
        public void FindMonthDaysCountInvalid()
        {
            DataService ds = new DataService();

            // Mois invalides
            Assert.AreEqual(-1, ds.FindMonthDaysCount(0));
            Assert.AreEqual(-1, ds.FindMonthDaysCount(13));
            Assert.AreEqual(-1, ds.FindMonthDaysCount(-5));
            Assert.AreEqual(-1, ds.FindMonthDaysCount(100));
        }

        [TestMethod]
        public void FindMonthDaysCountBoundary()
        {
            DataService ds = new DataService();

            // Limites valides
            Assert.AreEqual(31, ds.FindMonthDaysCount(1));
            Assert.AreEqual(31, ds.FindMonthDaysCount(12));

            // Limites invalides
            Assert.AreEqual(-1, ds.FindMonthDaysCount(0));
            Assert.AreEqual(-1, ds.FindMonthDaysCount(13));
        }
    }
}
    