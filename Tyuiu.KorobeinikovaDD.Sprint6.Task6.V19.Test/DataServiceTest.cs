using Tyuiu.KorobeinikovaDD.Sprint6.Task6.V19.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint6.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask6V19.txt";
            DataService ds = new DataService();
            string str = "";

            string wait = "HqrXl VLjXpq PAlR TwlB GGLDMUi AWkgYPxilmC";
            string res = ds.CollectTextFromFile(str, path);

            Assert.AreEqual(wait, res);
        }
    }
}