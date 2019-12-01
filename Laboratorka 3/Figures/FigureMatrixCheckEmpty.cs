using Laboratorka_3.SparseMatrix;

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