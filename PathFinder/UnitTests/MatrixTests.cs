using System.Collections.Generic;
using PathFinder.Models;
using Xunit;

namespace UnitTests;

public class MatrixTests
{
    [Fact]
    public void Can_Set_Path()
    {
        var sut = new Matrix(10, 10);

        List<Point> path = new List<Point> { new Point(0, 0), new Point(0, 1), new Point(1, 1), new Point(2, 1), new Point(2, 2) };

        sut.SetSolution(path);

        var expected = @" 3 3 0 0 0 0 0 0 0 0
 0 3 0 0 0 0 0 0 0 0
 0 3 3 0 0 0 0 0 0 0
 0 0 0 0 0 0 0 0 0 0
 0 0 0 0 0 0 0 0 0 0
 0 0 0 0 0 0 0 0 0 0
 0 0 0 0 0 0 0 0 0 0
 0 0 0 0 0 0 0 0 0 0
 0 0 0 0 0 0 0 0 0 0
 0 0 0 0 0 0 0 0 0 0
";

        Assert.Equal(expected, sut.ToString());
    }
}