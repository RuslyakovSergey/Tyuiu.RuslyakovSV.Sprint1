using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RuslyakovSV.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return string.Empty;
            }

            string[] words = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                words[i] = word.Length > 1 ? word[^1] + word[..^1] : word;
            }

            return string.Join(" ", words);
        }
    }
}
