using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KorobeinikovaDD.Sprint6.Task6.V19.Lib
{
    public class DataService : ISprint6Task6V19
    {
        public string CollectTextFromFile(string path)
        {
            // Читаем все строки из файла
            var lines = File.ReadAllLines(path);
            var wordsWithL = new List<string>();

            foreach (var line in lines)
            {
                // Разбиваем строку на слова
                var words = line.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                // Фильтруем слова: должны содержать 'l' и не содержать 'J' и 'i'
                var filteredWords = words.Where(word =>
                    word.Contains('l', StringComparison.OrdinalIgnoreCase));
                wordsWithL.AddRange(filteredWords);
            }

            // Возвращаем результат в виде строки
            return string.Join(" ", wordsWithL);
        }
    }
}
