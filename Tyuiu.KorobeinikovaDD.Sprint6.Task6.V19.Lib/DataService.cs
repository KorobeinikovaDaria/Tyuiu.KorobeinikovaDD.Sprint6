using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KorobeinikovaDD.Sprint6.Task6.V19.Lib
{
    public class DataService : ISprint6Task6V19
    {
        public string CollectTextFromFile(string path)
        {
            StringBuilder result = new StringBuilder();

            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                var words = line.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    if (word.IndexOf('l', StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        result.Append(word + " ");
                    }
                }
            }
            return result.ToString().Trim();
        }
    }
}
