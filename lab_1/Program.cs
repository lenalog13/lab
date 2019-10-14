using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0, d;
            String buf = "";
            bool boole = false;
            double[] mass = new double[3];

            Console.Title = "Логинова Елена, ИУ5-33Б";

            if (args.Length == 3)
            {
                if (!Double.TryParse(args[0], out a))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректные коэффициенты!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (!Double.TryParse(args[1], out b))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректные коэффициенты!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (!Double.TryParse(args[2], out c))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректные коэффициенты!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Введите коэффициенты");
                Console.Write("a = ");
                buf = Console.ReadLine();
                while (!Double.TryParse(buf, out a))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Некорректные коэффициенты! Повторите:");
                    Console.ForegroundColor = ConsoleColor.White;
                    buf = Console.ReadLine();
                }
                Console.Write("b = ");
                buf = Console.ReadLine();
                while (!Double.TryParse(buf, out b))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Некорректные коэффициенты! Повторите:");
                    Console.ForegroundColor = ConsoleColor.White;
                    buf = Console.ReadLine();
                }
                Console.Write("c = ");
                buf = Console.ReadLine();
                while (!Double.TryParse(buf, out c))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Некорректные коэффициенты! Повторите:");
                    Console.ForegroundColor = ConsoleColor.White;
                    buf = Console.ReadLine();
                }
            }



            if (a != 0)
            {
                c = b * b - 4 * a * c;
                if (c >= 0)
                {
                    c = Math.Sqrt(c);
                    b *= -1;
                    d = (b - c) / 2 / a;
                    a = (b + c) / 2 / a;
                    b = 1;
                    if (d >= 0)
                    {
                        d = Math.Sqrt(d);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("корень №1: ", d, ", корень №2: ", -d);
                        Console.ResetColor();
                    }
                    else boole = true;
                    if (a >= 0)
                    {
                        a = Math.Sqrt(a);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" корень №3: ", a, ", корень №4:", -a);
                        Console.ResetColor();
                    }
                    else if (boole == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Действительных корней нет!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Действительных корней нет!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                if (b == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней нет");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                d = (-1) * (4 * b * c);
                if (d >= 0)
                {
                    d = Math.Sqrt(d);
                    a = d / 2 / b;
                    b = -d / 2 / b;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"корень №1: {a}, корень №2: {b}");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Действительных корней нет!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.ReadKey();
        }
    }
}