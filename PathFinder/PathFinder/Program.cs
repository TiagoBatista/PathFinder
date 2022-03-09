using PathFinder.Algorithms;
using PathFinder.Models;

var matrix = new Matrix(10, 10);

var algorithm = new Dijkstra();

var endPoint = new Point(9,9);
var startPoint = new Point(0,1);
var path = algorithm.Solve(matrix, startPoint, endPoint);

matrix.SetSolution(path);

Console.WriteLine(matrix);
Console.ReadLine();