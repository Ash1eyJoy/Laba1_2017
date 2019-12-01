using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laboratorka_3
{
    public class Square : Rectangle
    {
        public Square(double side) : base(side, side) { }

        public override string ToString()
        {
            return $"Квадрат со стороной {Height} имеет площадь {Area()}";
        }
    }
}