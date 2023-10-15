using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.MorozAD.Sprint1.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #1 | Выполнил : Мороз А.Д |СМАРТб- 23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Работа со строками класс String                                *");
            Console.WriteLine("* Задние # 6                                                           *");
            Console.WriteLine("* Вариант #14                                                          *");
            Console.WriteLine("* Выполнил : Мороз А.Д | СМАРТб- 23-1                                  *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Условие:                                                             *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                       *");
            Console.WriteLine("* Проверить, что строка составлена только из строчных русских букв.    *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");

            string a;
            string h;
            Console.WriteLine("Введите Строку: ");
            a = Convert.ToString(Console.ReadLine());
            h = a.ToLower();
     
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine(a.Equals(h));
            Console.ReadKey();
        }
    }
}
