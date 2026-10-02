using Tyuiu.RuslyakovSV.Sprint1.Task6.V9.Lib;

namespace Tyuiu.RuslyakovSV.Sprint1.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Русляков С. В. | ПКТб-26-1";
            Console.WriteLine("************************************************************");
            Console.WriteLine("* Спринт #1                                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                           *");
            Console.WriteLine("* Задание #6                                                 *");
            Console.WriteLine("* Вариант #9                                                 *");
            Console.WriteLine("* Выполнил: Русляков Сергей Владимирович | ПКТб-26-1        *");
            Console.WriteLine("************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Пользователь вводит текст. Напечатать все слова,           *");
            Console.WriteLine("* перенеся их последнюю букву в начало.                      *");
            Console.WriteLine("************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("************************************************************");

            Console.Write("Введите текст: ");
            string text = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("************************************************************");
            Console.WriteLine(ds.MoveLetterToStart(text));
            Console.ReadKey();
        }
    }
}
