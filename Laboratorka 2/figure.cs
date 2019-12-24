using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka_2
{
    public abstract class Figure: IComparable
    {
        public string Type
        {
            get
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        string _Type;

        public abstract double Area();

        public override string ToString()
        {
            return this._Type + this.Area().ToString();
        }

        public int CompareTo(object obj)
        {
            var figure = (Figure)obj;
            if (this.Area() < figure.Area()) return -1;
            if (this.Area() == figure.Area()) return 0;
            return 1;
        }
    }
}
