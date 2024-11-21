using Tyuiu.KorobeinikovaDD.Sprint6.Task0.V21.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint6.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = 2;
            double res = ds.Calculate(x);
            double wait = 13;
            Assert.AreEqual(wait, res);
        }
    }
}