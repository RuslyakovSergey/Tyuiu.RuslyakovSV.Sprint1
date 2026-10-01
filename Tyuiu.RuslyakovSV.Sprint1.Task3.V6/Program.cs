using Tyuiu.RuslyakovSV.Sprint1.Task3.V6.Lib;

// ЗАДАНИЕ
// Написать программу, которая запрашивает у пользователя исходные данные,
// выполняет указанные расчёты и печатает результат на экране.
// Вычислить стоимость поездки на автомобиле на дачу туда и обратно.

namespace Tyuiu.RuslyakovSV.Sprint1.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Русляков Сергей Владимирович | ПКТб-23-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
            Console.WriteLine("* Задание #3                                                                 *");
            Console.WriteLine("* Вариант #6                                                                 *");
            Console.WriteLine("* Выполнил: Русляков Сергей Владимирович | ПКТб-23-1                         *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Вычислить стоимость поездки на автомобиле на дачу туда и обратно.           *");
            Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                                  *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("*******************************************************************************");

            Console.Write("Расстояние до дачи (км): ");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Расход бензина (л на 100 км): ");
            double gasFlow = Convert.ToDouble(Console.ReadLine());
            Console.Write("Цена одного литра бензина (руб.): ");
            double gasPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Стоимость поездки туда и обратно = " + ds.TravelCost(distance, gasFlow, gasPrice));

            Console.ReadLine();
        }
    }
}
