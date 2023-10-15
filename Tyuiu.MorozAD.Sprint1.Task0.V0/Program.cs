using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAD.Sprint0.Task1.V0.Lib;



namespace Tyuiu.MorozAD.Sprint1.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #0 | Выполнил : Мороз А.Д |СМАРТб- 23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Базовые навыки работы С#                                       *");
            Console.WriteLine("* Задние # 0                                                           *");
            Console.WriteLine("* Вариант #5                                                           *");
            Console.WriteLine("* Выполнил : Мороз А.Д | СМАРТб- 23-1                                  *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Условие:                                                             *");
            Console.WriteLine("* Написать  программу, вычесляет выражение (1+2)*(1+9/3)               *");
            Console.WriteLine("* и печатает результат на экране.                                      *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* (1+2)*(1+9/3)                                                        *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");


            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}
