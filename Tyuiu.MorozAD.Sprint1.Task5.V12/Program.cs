using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.MorozAD.Sprint1.Task5.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил : Мороз А.Д |СМАРТб- 23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                           *");
            Console.WriteLine("* Задние # 5                                                           *");
            Console.WriteLine("* Вариант # 3                                                          *");
            Console.WriteLine("* Выполнил : Мороз А.Д | СМАРТб- 23-1                                  *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Условие:                                                             *");
            Console.WriteLine("* Присвоить целой переменной h третью                                  *");
            Console.WriteLine("* от конца цифру в записи положительного целого числа k.               *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            int k;
            string h;
            Console.WriteLine("Введите значение X:");
            k = Convert.ToInt32(Console.ReadLine());
            

            string s = k.ToString();
            char[] ar = s.ToCharArray();
            Array.Reverse(ar);
            s = new String(ar);
            k = Convert.ToInt32(s);
            h = Convert.ToString(k);
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine(h[2]);
            Console.ReadKey();
        }
    }
}
