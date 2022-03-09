using PathFinder.Algorithms;
using PathFinder.Models;
using Xunit;

namespace UnitTests;

public class AStarTests
{
    private readonly AStar sut = new AStar();

    [Fact]
    public void HappyPath()
    {
        var m = new Matrix(10, 10);
        var s = new Point(0, 0);
        var e = new Point(9, 9);

        var result = sut.Solve(m, s, e);

        Assert.NotNull(result);
    }
}