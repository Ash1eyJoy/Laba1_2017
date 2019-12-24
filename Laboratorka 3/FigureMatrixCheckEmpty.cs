using Laboratorka_3.SparseMatrix;
using Laba_2;

namespace Laboratorka_3
{
    public class FigureMatrixCheckEmpty : IMatrixCheckEmpty<Figure>
    {
        public Figure GetEmptyElement()
        {
            return null;
        }

        public bool CheckEmptyElement(Figure element)
        {
            return element == null;
        }
    }
}