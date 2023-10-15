using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAD.Sprint1.Task1.V7.Lib;

namespace Tyuiu.MorozAD.Sprint1.Task1.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил : Мороз А.Д |СМАРТб- 23-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                        *");
            Console.WriteLine("* Тема: Class Math                                                                                 *");
            Console.WriteLine("* Задние #4                                                                                        *");
            Console.WriteLine("* Вариант #7                                                                                       *");
            Console.WriteLine("* Выполнил : Мороз А.Д | СМАРТб- 23-1                                                              *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Условие:                                                                                         *");
            Console.WriteLine("* Написать  программу, которая вычесляет выражение (1 + (Math.Sqrt(x * y) /(Math.Pow((x-3*y),2)))) *");
            Console.WriteLine("* и печатает результат на экране.                                                                  *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("*  (1 + (Math.Sqrt(x * y) /(Math.Pow((x-3*y),2))))                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            double x;
            double y;
            double c;
         

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());
            c = (double)Math.Round(ds.Calculate(x,y),3);
            
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine(c);
            Console.ReadKey();
        }

    }
}
