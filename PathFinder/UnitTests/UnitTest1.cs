using System.Collections.Generic;
using PathFinder.Matrix;
using Xunit;

namespace UnitTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var sut = new Matrix(10, 10);

        List<(int, int)> path = new List<(int, int)>
        {
            (0,0),
            (0,1),
            (1,1),
            (2,1),
            (2,2)
        };
        
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