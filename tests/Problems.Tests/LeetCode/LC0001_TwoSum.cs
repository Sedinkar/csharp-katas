using Problems.LeetCode.LC0001.TwoSum;

namespace Problems.Tests.LeetCode;
[Trait("Kata", "LC0001")]
public class LC0001SolutionTests
{
    [Fact]
    public void TwoSum_SimpleCase()
    {
        var nums = new[] { 2, 7, 11, 15 };
        var target = 9;

        var result = new Solution().TwoSum(nums, target);

        Assert.Equal(new[] { 0, 1 }, result);
    }

    [Theory]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    [InlineData(new int[] { 0, 4, 3, 0 }, 0, new int[] { 0, 3 })]
    [InlineData(new int[] { -3, 4, 3, 90 }, 0, new int[] { 0, 2 })]
    public void TwoSum_VariousArrays(int[] nums, int target, int[] expected)
    {
        var result = new Solution().TwoSum(nums, target);
        Assert.Equal(expected, result);
    }
}
