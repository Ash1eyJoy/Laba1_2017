using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka_3.SparseMatrix
{
    public interface IMatrixCheckEmpty<T>
    {
        T GetEmptyElement();

        bool CheckEmptyElement(T element);
    }
}