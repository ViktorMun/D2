using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time1 = DateTime.Now;
            int total = 0;
            for (int i = 1; i < 1000000000; i++)
            {
                if (goodNum(i)) total++;
            }


            Console.WriteLine("Хорошие числа: " + total);
            DateTime time2 = DateTime.Now;
            Console.WriteLine("Время выполнения: {0}", (time2 - time1));
            Console.ReadKey();
        }


        static bool goodNum(int i)
        {
            int x = i;
            int e = 0;
            while (x > 0)
            {
                e += x % 10;
                x /= 10;
            }
            return i % e == 0;
        }
    }
}