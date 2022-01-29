using PathFinder.Algorithms;
using PathFinder.Matrix;

var matrix = new Matrix(10, 10);

IAlgorithm algorithm = new Dijkstra(matrix, (0,1), (9,9));

List<(int,int)> path = algorithm.Solve();

matrix.SetSolution(path);

Console.WriteLine(matrix);

Console.ReadLine();