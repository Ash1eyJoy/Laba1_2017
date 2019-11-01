using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Title = "Ахвердиев Валерий ИУ5-31Б";
            double A, B, C, X1, X2, X3, X4;
            if (args.Length == 3)
            {
                double.TryParse(args[0], out A);
                double.TryParse(args[1], out B);
                double.TryParse(args[2], out C);
            }
            else
            {
                Console.Write("A = ");
                string str = Console.ReadLine();
                bool ConvertResult = double.TryParse(str, out A);
                if (!ConvertResult)
                {
                    bool ConvertResult0;
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неправильный коэффицент");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("A = ");
                        string str0 = Console.ReadLine();
                        ConvertResult0 = double.TryParse(str0, out A);


                    } while (!ConvertResult0);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("B = ");
                str = Console.ReadLine();
                ConvertResult = double.TryParse(str, out B);
                if (!ConvertResult)
                {
                    bool ConvertResult0;
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неправильный коэффицент");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("B = ");
                        string str0 = Console.ReadLine();
                        ConvertResult0 = double.TryParse(str0, out B);


                    } while (ConvertResult0 == false);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("C = ");
                str = Console.ReadLine();
                ConvertResult = double.TryParse(str, out C);
                if (!ConvertResult)
                {
                    bool ConvertResult0;
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неправильный коэффицент");
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.Write(" C = ");
                        string str0 = Console.ReadLine();
                        ConvertResult0 = double.TryParse(str0, out C);


                    } while (!ConvertResult0);
                }
                Console.ForegroundColor = ConsoleColor.White;

            }
            if (A == 0 && B == 0)
            {
                if (C == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корни - любые числа.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Нет корней");
                }
                Console.ReadKey();
            }
            if (A == 0)
            {
                if (B != 0)
                {
                    if (C / B > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Нет корней");
                    }
                    else
                    {
                        X1 = Math.Sqrt(-C / B);
                        X2 = (-1) * X1;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения: {0}, {1}.", X1, X2);
                    }
                }
            }
            else
            if (B == 0)
            {
                double k;
                if (C / A > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Нет корней");
                }
                else
                {
                    k = Math.Sqrt(-C / A);
                    X1 = Math.Sqrt(k);
                    X2 = (-1) * X1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корни уравнения: {0}, {1}.", X1, X2);
                }
            }
            else
            {
                double D, D1, D2, D3;
                D = B * B - 4 * A * C;
                if (D < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Нет корней");
                }
                else
                {
                    D1 = Math.Sqrt(D);
                    D2 = (-B + D1) / (2 * A);
                    if (D2 > 0)
                    {
                        X1 = Math.Sqrt(D2);
                        X2 = (-1) * X1;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения: {0}, {1}", X1, X2);
                        D3 = (-B - D1) / (2 * A);
                        if (D3 > 0)
                        {
                            X3 = Math.Sqrt(D3);
                            X4 = (-1) * X3;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0}, {1}.", X3, X4);
                        }
                        else Console.Write(".");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Нет корней");
                    }
                }

            }
            Console.ReadKey();
        }
    }
}