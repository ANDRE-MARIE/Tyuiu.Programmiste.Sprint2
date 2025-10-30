using Tyuiu.Programmiste.Sprint2.Task2.V9.Lib;

namespace Tyuiu.Programmiste.Sprint2.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckPointInTriangleArea()
        {

            {
                DataService ds = new DataService();

                // Points dans le triangle
                Assert.IsTrue(ds.CheckDotInShadedArea(0, 0));
                Assert.IsTrue(ds.CheckDotInShadedArea(5, 5));
                Assert.IsTrue(ds.CheckDotInShadedArea(10, 0));
                Assert.IsTrue(ds.CheckDotInShadedArea(0, 10));
            }


            {
                DataService ds = new DataService();

                // Points dans le rectangle
                Assert.IsTrue(ds.CheckDotInShadedArea(5, 3));
                Assert.IsTrue(ds.CheckDotInShadedArea(10, 8));
                Assert.IsTrue(ds.CheckDotInShadedArea(7, 5));
            }


            {
                DataService ds = new DataService();

                // Points en dehors de toutes les zones
                Assert.IsFalse(ds.CheckDotInShadedArea(12, 10));
                Assert.IsFalse(ds.CheckDotInShadedArea(20, 5));
                Assert.IsFalse(ds.CheckDotInShadedArea(5, 12));
                Assert.IsFalse(ds.CheckDotInShadedArea(-1, 5));
            }


            {
                DataService ds = new DataService();

                // Points aux limites
                Assert.IsTrue(ds.CheckDotInShadedArea(15, 0));  // Limite triangle
                Assert.IsTrue(ds.CheckDotInShadedArea(0, 15));  // Limite triangle
                Assert.IsTrue(ds.CheckDotInShadedArea(5, 8));   // Limite rectangle
            }
        }
    }
}