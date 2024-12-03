using Tyuiu.KorobeinikovaDD.Sprint6.Task5.V21.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint6.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask5V21.txt";
            DataService ds = new DataService();

            double[] wait;
            wait = new double[2];
            wait[0] = 12;
            wait[1] = -9;
            
            double[] valueArray;
            valueArray = ds.LoadFromDataFile(path);

            CollectionAssert.AreEqual(wait, valueArray);
        }
    }
}