using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2.	Написать метод подсчета количества цифр числа.*/
namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            while (n != 0)
            {
                count++;
                n = n / 10;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
