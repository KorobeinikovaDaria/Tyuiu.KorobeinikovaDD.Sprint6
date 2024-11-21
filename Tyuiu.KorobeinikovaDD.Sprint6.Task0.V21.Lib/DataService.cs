using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KorobeinikovaDD.Sprint6.Task0.V21.Lib
{
    public class DataService : ISprint6Task0V21
    {
        public double Calculate(int x)
        {
            double y = 2 * Math.Pow(x, 3) + 0.5 * x * x - 3.5 * x + 2;
            return Math.Round(y, 3);
        }
    }
}
