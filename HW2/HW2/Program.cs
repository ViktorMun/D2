using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 7.	a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
//      б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.

/// </summary>
namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое значение:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе значение:");
            int b = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            Loop(a, b, total);
            Console.ReadKey();
        }

        static void Loop(int a, int b, int total)
        {

            if (a < b)
            {
                Console.WriteLine("{0,4} ", a);
                total += a;
                Loop(a + 1, b, total);
            }
            else
                Console.WriteLine("Сумма чисел: " + total);
        }
    }
}