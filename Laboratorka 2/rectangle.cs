using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka_2
{
    class Rectangle : Figure, IPrint
    {
        double height;
        double width;

        public Rectangle(double h, double w)
        {
            this.height = h;
            this.width = w;
            this.Type = "Площадь прямоугольника = ";
        }

        public override double Area()
        {
            double result = this.height * this.width;
            return result;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
