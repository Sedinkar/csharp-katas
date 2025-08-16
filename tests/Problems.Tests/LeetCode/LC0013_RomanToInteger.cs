using Problems.LeetCode.LC0013.RomanToInteger;

namespace Problems.Tests.LeetCode;
[Trait("Kata", "LC0013")]
public class LC0013SolutionTests
{
    [Fact]
    public void SingleRomanToInteger()
    {
        var s = "XVIII";

        var result = Solution.RomanToInt(s);

        Assert.Equal(18, result);
    }

    [Theory]
    [InlineData("XV",15)]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void VariousArraysReturnsResults(string s, int expected)
    {
        var result = Solution.RomanToInt(s);
        Assert.Equal(expected, result);
    }
}
