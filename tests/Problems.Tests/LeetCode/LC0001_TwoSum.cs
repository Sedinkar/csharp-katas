using Problems.LeetCode.LC0001.TwoSum;

namespace Problems.Tests.LeetCode;
[Trait("Kata", "LC0001")]
public class LC0001SolutionTests
{
    [Fact]
    public void TwoSumSimpleCase()
    {
        var nums = new[] { 2, 7, 11, 15 };
        var target = 9;

        var result = Solution.TwoSum(nums, target);
        var expected = new[] { 0, 1 };
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    [InlineData(new int[] { 0, 4, 3, 0 }, 0, new int[] { 0, 3 })]
    [InlineData(new int[] { -3, 4, 3, 90 }, 0, new int[] { 0, 2 })]
    public void TwoSumVariousArrays(int[] nums, int target, int[] expected)
    {
        var result = Solution.TwoSum(nums, target);
        Assert.Equal(expected, result);
    }
}
