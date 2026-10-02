using Tyuiu.RuslyakovSV.Sprint1.Task5.V6.Lib;

// ЗАДАНИЕ
// Пусть k — целое от 1 до 365. Определить номер дня недели
// для k-го дня невисокосного года, если 1 января — понедельник.

namespace Tyuiu.RuslyakovSV.Sprint1.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Русляков Сергей Владимирович | ПКТб-26-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
            Console.WriteLine("* Задание #5                                                                 *");
            Console.WriteLine("* Вариант #6                                                                 *");
            Console.WriteLine("* Выполнил: Русляков Сергей Владимирович | ПКТб-26-1                         *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* По номеру дня определить день недели невисокосного года.                   *");
            Console.WriteLine("* 1 января — понедельник.                                                     *");
            Console.WriteLine("*******************************************************************************");

            Console.Write("Введите номер дня k (от 1 до 365): ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Номер дня недели = " + ds.Calculate(k));

            Console.ReadLine();
        }
    }
}
