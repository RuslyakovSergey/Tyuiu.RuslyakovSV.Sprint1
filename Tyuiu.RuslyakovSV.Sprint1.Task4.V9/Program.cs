using Tyuiu.RuslyakovSV.Sprint1.Task4.V9.Lib;

// ЗАДАНИЕ
// Написать программу, которая запрашивает у пользователя исходные данные,
// вычисляет результат по формуле и печатает его на экране.
// Формула: ln(xy) / (x - sqrt(1 + y^2))

namespace Tyuiu.RuslyakovSV.Sprint1.Task4.V9
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
            Console.WriteLine("* Задание #4                                                                 *");
            Console.WriteLine("* Вариант #9                                                                 *");
            Console.WriteLine("* Выполнил: Русляков Сергей Владимирович | ПКТб-26-1                         *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Вычислить результат по формуле ln(xy) / (x - sqrt(1 + y^2)).                *");
            Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                                  *");
            Console.WriteLine("*******************************************************************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Результат = " + ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
