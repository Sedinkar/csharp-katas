using Problems.ChatGPT.GPT0002.TriangleArea;

namespace Problems.Tests.ChatGPT;
[Trait("Kata", "GPT0002")]
public class GPT0002SolutionTests
{
    [Fact]
    public void SingleElementReturnsThatElement()
    {
        var result = Solution.TriangleArea(3, 4, 5);
        Assert.Equal(6, result);
    }

    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(5, 12, 13, 30)]
    [InlineData(10, 10, 10, 43.3012701892)]
    [InlineData(2, 2, 3, 1.9843134833)]
    [InlineData(7.5, 7.5, 4, 14.4568322948)]
    public void ValidTrianglesReturnsArea(double a, double b, double c, double expected)
    {
        var result = Solution.TriangleArea(a, b, c);
        Assert.Equal(expected, result, precision: 6);
    }

    [Theory]
    [InlineData(0, 4, 5, "a")]
    [InlineData(4, 0, 5, "b")]
    [InlineData(4, 5, 0, "c")]
    [InlineData(-1, 2, 3, "a")]
    public void NonPositiveSideThrowsArgumentOutOfRange(double a, double b, double c, string paramName)
    {
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => Solution.TriangleArea(a, b, c));
        Assert.Equal(paramName, ex.ParamName);
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(10, 1, 1)]
    [InlineData(2, 10, 2)]
    public void TriangleInequalityViolationThrowsArgumentException(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => Solution.TriangleArea(a, b, c));
    }
}
