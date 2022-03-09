using PathFinder.Models;

namespace PathFinder.Algorithms;

public interface IAlgorithm
{
    List<Point> Solve(Matrix matrix, Point startPoint, Point endPoint);
}