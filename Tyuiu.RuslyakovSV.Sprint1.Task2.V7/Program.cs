using Tyuiu.RuslyakovSV.Sprint1.Task2.V7.Lib;

namespace Tyuiu.RuslyakovSV.Sprint1.Task2.V7
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
            Console.WriteLine("* Задание #2                                                                 *");
            Console.WriteLine("* Вариант #7                                                                 *");
            Console.WriteLine("* Выполнил: Русляков Сергей Владимирович | ПКТб-26-1                         *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Известен радиус круга. Вычислить примерную площадь круга.                   *");
            Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                                  *");
            Console.WriteLine("*******************************************************************************");

            Console.Write("Введите радиус круга: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            double area = Math.Round(Math.PI * ds.Sqr(radius), 3);

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Площадь круга = " + area);
            Console.ReadLine();
        }
    }
}
