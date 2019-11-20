using Laboratorka_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lab_2
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.Title = "Ахвердиев Валерий  ИУ5-31Б";
            double a, b;
            Console.WriteLine("Введите длину прямоугольника");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту прямоугольника");
            b = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(a, b);
            rectangle.Print();
            Console.WriteLine("Введите сторону квадрата");
            a = double.Parse(Console.ReadLine());
            Square square = new Square(a);
            square.Print();
            Console.WriteLine("Введите радиус круга");
            a = double.Parse(Console.ReadLine());
            Circle circle = new Circle(a);
            circle.Print();
            Console.ReadLine();
        }
    }

   
}