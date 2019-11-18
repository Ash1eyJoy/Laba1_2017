using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka_2
{
    class Circle : Figure, IPrint
    {
        double radius;

        public Circle(double rd)
        {
            this.radius = rd;
            this.Type = "Площадь круга = ";
        }

        public override double Area()
        {
            double result = Math.PI * this.radius * this.radius;
            return result;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
}
}
