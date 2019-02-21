using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.	Написать метод, возвращающий минимальное из трёх чисел.*/
namespace HW2
{
    class MinFromThree
    {
        static void Main(string[] args)
        {
            int a, b, c, max;
            Console.WriteLine("Введите три целых числа.");
            Console.Write("Первое число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Третье число:");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a>c)
            {
                max = a;
            }
            else if (b > c)
            {
                max = b;
            }
            else { max = c; }
            Console.WriteLine("Наибольшее число {0}", max);
            Console.WriteLine("Для выхода из приложение нажмите Enter");
            Console.ReadLine();
        }

    }
}

