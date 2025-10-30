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

            Assert.AreEqual("spades", ds.FindCardSuit(1));    // CORRECTION : AreEqual
            Assert.AreEqual("clubs", ds.FindCardSuit(2));     // CORRECTION : AreEqual
            Assert.AreEqual("diamonds", ds.FindCardSuit(3));  // CORRECTION : AreEqual
            Assert.AreEqual("hearts", ds.FindCardSuit(4));    // CORRECTION : AreEqual
        }

        [TestMethod]
        public void FindCardSuitInvalidNumber()
        {
            DataService ds = new DataService();
            Assert.AreEqual("unknown suit", ds.FindCardSuit(5));  // CORRECTION : AreEqual
        }

        [TestMethod]
        public void FindCardSuitValidClubs()
        {
            DataService ds = new DataService();
            string result = ds.FindCardSuit(2);
            Assert.AreEqual("clubs", result);  // CORRECTION : AreEqual
        }
    }
}
