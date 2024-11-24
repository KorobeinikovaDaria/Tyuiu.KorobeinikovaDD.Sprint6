using Tyuiu.KorobeinikovaDD.Sprint6.Task2.V2.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint6.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();


            int startValue = -5;
            int stopValue = 5;

            int len = (stopValue - startValue) + 1;

            double[] wait;
            wait = new double[len];

            wait[0] = 6.49;
            wait[1] = -9.88;
            wait[2] = -12.26;
            wait[3] = -4.60;
            wait[4] = 0.52;
            wait[5] = 4;
            wait[6] = -0.75;
            wait[7] = 4.55;
            wait[8] = 12.23;
            wait[9] = 9.86;
            wait[10] = -6.50;

            double[] valueArray;
            valueArray = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(wait, valueArray);
        }
    }
}