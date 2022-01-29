using PathFinder.Algorithms;
using PathFinder.Matrix;

public class Dijkstra : IAlgorithm
{
    private readonly Matrix _matrix;
    private readonly (int, int) _startPoint;
    private readonly (int, int) _endPoint;

    public Dijkstra(Matrix matrix, (int, int) startPoint, (int, int) endPoint)
    {
        _matrix = matrix;
        _startPoint = startPoint;
        _endPoint = endPoint;
    }

    public List<(int, int)> Solve()
    {
        throw new NotImplementedException();
    }
}