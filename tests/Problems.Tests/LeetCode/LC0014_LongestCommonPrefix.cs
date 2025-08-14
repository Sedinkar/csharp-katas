using Problems.LeetCode.LC0014.LongestCommonPrefix;

namespace Problems.Tests.LeetCode;
[Trait("Kata", "LC0014")]
public class LC0014SolutionTests
{
    [Fact]
    public void SingleElementReturnsThatElement()
    {
        string[] test = new string[] { "flower", "flow", "flight" };
        var result = Solution.LongestCommonPrefix(test);
        Assert.Equal("fl", result);
    }

    [Theory]
    [InlineData(new string[] { "dog", "racecar", "car" }, "")]
    [InlineData(new string[] { "a" }, "a")]
    [InlineData(new string[] { "", "b" }, "")]
    [InlineData(new string[] { "ab", "a" }, "a")]
    [InlineData(new string[] { "interspecies", "interstellar", "interstate" }, "inters")]
    public void VariousArraysReturnsResults(string[] strs, string expected)
    {
        var result = Solution.LongestCommonPrefix(strs);
        Assert.Equal(expected, result);
    }
}
