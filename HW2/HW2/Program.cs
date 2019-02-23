using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 5.	а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
//      б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
/// </summary>
namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа расчета индекса массы тела");
            Console.WriteLine("Введите ваш вес:");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш рост в метрах:");
            double h = Convert.ToDouble(Console.ReadLine());
            double l = m / (h * h);
            double minM = m-( Math.Round(l,5) * h * h);
            Console.WriteLine($"Ваш индекс массы тела: {Math.Round(l, 2)}");
            if (l < 18.5) Console.WriteLine( $"Вам нужно набрать {minM} кг");
            else if (l < 26) Console.WriteLine( $"У вас нормальный вес");
            else if (l < 30) Console.WriteLine( $"Вам нужно сбросить { minM} кг");
            else Console.WriteLine($"Вам нужно сбросить {minM} кг");
           Console.ReadLine();

        }
    }
}
