using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAD.Sprint1.Task2.V12.Lib;

namespace Tyuiu.MorozAD.Sprint1.Task1.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил : Мороз А.Д |СМАРТб- 23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Базовые навыки работы С#                                       *");
            Console.WriteLine("* Задние # 2                                                         *");
            Console.WriteLine("* Вариант #12                                                          *");
            Console.WriteLine("* Выполнил : Мороз А.Д | СМАРТб- 23-1                                  *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Условие:                                                             *");
            Console.WriteLine("* Написать  программу,которая вычесляет объем параллелепипеда.         *");
            Console.WriteLine("* и печатает результат на экране.                                      *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            int x;
            int y;
            int z;


            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Z:");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CalculateParallelepipedVolume(x,y,z));
            Console.ReadLine();
            Console.WriteLine("************************************************************************");
        }
    }
}
