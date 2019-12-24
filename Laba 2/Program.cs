using System;

namespace Laba_2
{
    class Program
    {
        static void PrintFigure(Figure figure)
        {
            var num = figure.Area();
            Console.WriteLine(num);
            figure.Print();
        }
        static void Main(string[] args)
        {
            Console.Title = "Ахвердиев Валерий  ИУ5-31Б";
            double a, b, c, d;
            Console.WriteLine("Введите длину прямоугольника");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту прямоугольника");
            b = double.Parse(Console.ReadLine());
            var rect = new Rectangle(a, b);
            rect.Print();
            Console.WriteLine("Введите сторону квадрата");
            c = double.Parse(Console.ReadLine());
            var sqr = new Square(c);
            sqr.Print();
            Console.WriteLine("Введите радиус круга");
            d = double.Parse(Console.ReadLine());
            var crl = new Circle(d);
            crl.Print();





            Console.WriteLine();

            PrintFigure(rect);
            PrintFigure(sqr);
            PrintFigure(crl);
            Console.ReadKey();
        }
    }
}