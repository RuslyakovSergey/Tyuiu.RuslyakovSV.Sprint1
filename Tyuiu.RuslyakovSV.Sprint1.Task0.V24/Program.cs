using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RuslyakovSV.Sprint1.Task0.V24.Lib;

//ЗАДАНИЕ
//Написать программу, которая вычисляет выражение 2*4/4/2+1 и печатает результат на экране.

namespace Tyuiu.RuslyakovSV.Sprint1.Task0.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Русляков С. В. | ПКТб-26-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                            *");
            Console.WriteLine("* Задание #0                                                                 *");
            Console.WriteLine("* Вариант #24                                                                *");
            Console.WriteLine("* Выполнил: Русляков Сергей Владимирович | ПКТб-26-1                        *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 2*4/4/2+1                 *");
            Console.WriteLine("* и печатает результат на экране.                                             *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* 2*4/4/2+1                                                                 *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("*******************************************************************************");
            
            Console.WriteLine(ds.Calculate());

            Console.ReadLine();
        }
    }
}
