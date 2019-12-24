using System;

namespace Laba_2
{
    public abstract class Figure : IPrint, IComparable
    {
        public abstract double Area();
        public void Print()
        {
            Console.WriteLine(ToString());
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