using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka_2
{
    class Square : Rectangle
    {

        public Square(double length) : base(length, length) { }
        public override string ToString()
        {
            return "Площадь квадрата =  " + Area().ToString();
        }

    }
}
