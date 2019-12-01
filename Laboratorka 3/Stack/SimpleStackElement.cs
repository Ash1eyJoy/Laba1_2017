using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka_3.Stack
{
    public class SimpleStackElement<T>
    {
        public T Data { get; set; }
        public SimpleStackElement<T> Next { get; set; }

        public SimpleStackElement(T data)
        {
            Data = data;
        }
    }
}