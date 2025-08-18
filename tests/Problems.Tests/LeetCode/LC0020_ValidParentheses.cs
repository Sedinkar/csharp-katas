using Problems.LeetCode.LC0020.ValidParentheses;

namespace Problem.Tests.LeetCode;
[Trait("Kata", "LC0020")]

public class LC0020ValidParentheses
{
    [Fact]
    public void SingleTest()
    {
        string s = "{{()}}";
        var result = Solution.IsValid(s);
        Assert.True(result);
    }
    [Theory]
    [InlineData("(", false)]
    [InlineData("]", false)]
    [InlineData("({[", false)]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)]
    [InlineData("{[]}", true)]
    [InlineData("((()))", true)]
    [InlineData("(([]{})", false)]
    [InlineData("(((((((", false)]
    [InlineData("]}]]}", false)]
    [InlineData("{}{}[](())", true)]
    public void MultipleTest(string s, bool expected)
    {
        var result = Solution.IsValid(s);
        Assert.Equal(expected, result);
    }
}