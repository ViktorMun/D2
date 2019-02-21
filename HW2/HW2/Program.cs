using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{ /// <summary>
/// 4.	Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Login:");
           string login = Console.ReadLine();
            Console.Write("Psw:");
           string password =Console.ReadLine();
            int a = 0;
            do
            {
                a++;
                if (login == "root" && password == "GeekBrains")
                {
                    Console.WriteLine("NEXT");
                    break;
                }
                else Console.WriteLine("Логин или пароль неверен");
                Console.Write("Login:");
                 login = Console.ReadLine();
                Console.Write("Psw:");
                password = Console.ReadLine();
            } while (a<2);
            Console.ReadKey();
        }
    }
}
