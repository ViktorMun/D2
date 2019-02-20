using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3.	С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных положительных чисел.*/
namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0, s = 0;
            Console.WriteLine("Введите числа:");
            int a = int.Parse(Console.ReadLine());
            while (a != 0)
            {
                if (a % 2 != 0&& a>0) { s += a; }
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Сумма нечетных чисел {s}");
            Console.ReadKey();

        }
    }
}