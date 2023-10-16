using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAD.Sprint1.Task7.V2.Lib;

namespace Tyuiu.MorozAD.Sprint1.Task7.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил : Мороз А.Д |СМАРТб- 23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту              *");
            Console.WriteLine("* Задние # 7                                                           *");
            Console.WriteLine("* Вариант #2                                                           *");
            Console.WriteLine("* Выполнил : Мороз А.Д | СМАРТб- 23-1                                  *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Условие:                                                             *");
            Console.WriteLine("*Написать программу, которая вычисляет математическое выражение        *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");

            double x,y,c;
            
            Console.WriteLine("Введите X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y: ");
            y= Convert.ToDouble(Console.ReadLine());
            c = (double)Math.Round(ds.Calculate(x, y), 3);
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine(c);
            Console.ReadKey();
            
        }
    }
}
