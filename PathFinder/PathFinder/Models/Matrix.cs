using System.Text;

namespace PathFinder.Models;

public class Matrix
{
    private readonly Cell[,] _cells;

    public Matrix(int rows, int columns)
    {
        _cells = new Cell[rows, columns];
        Initialize();
    }

    private void Initialize()
    {
        for (int i = 0; i < _cells.GetLength(0); i++)
        {
            for (int j = 0; j < _cells.GetLength(1); j++)
            {
                _cells[i, j] = new Cell();
            }
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        for (int i = 0; i < _cells.GetLength(0); i++)
        {
            for (int j = 0; j < _cells.GetLength(1); j++)
            {
                sb.Append(' ');
                sb.Append(_cells[i, j]);
            }

            sb.Append("\n");
        }

        return sb.ToString();
    }

    public void SetSolution(List<Point> path)
    {
        path.ForEach(p => _cells[p.x, p.y].MarkAsPartOfSolution());
    }
}