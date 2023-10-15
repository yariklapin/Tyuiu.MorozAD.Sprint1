using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAD.Sprint1.Task3.V2.Lib;

namespace Tyuiu.MorozAD.Sprint1.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил : Мороз А.Д |СМАРТб- 23-1";
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                     *");
            Console.WriteLine("* Тема: Базовые навыки работы С#                                                *");
            Console.WriteLine("* Задние # 0                                                                    *");
            Console.WriteLine("* Вариант #5                                                                    *");
            Console.WriteLine("* Выполнил : Мороз А.Д | СМАРТб- 23-1                                           *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Условие:                                                                      *");
            Console.WriteLine("* Написать  программу,которая стоимости покупки                                 *");
            Console.WriteLine("*состоящей из нескольких тетрадей и карандашей, и печатает результат на экране. *");
            Console.WriteLine("*                                                                               *");
            Console.WriteLine("*********************************************************************************");

            double x;
            int x1;
            double y;
            int y1;


            Console.WriteLine("Введите стоимость тетради :");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите колл-во тетрадей:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость карандаша:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите колл-во карандашей:");
            y1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                    *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine(ds.PurchaseAmount(x, x1, y, y1));
            Console.ReadKey();
        }
    }
}
