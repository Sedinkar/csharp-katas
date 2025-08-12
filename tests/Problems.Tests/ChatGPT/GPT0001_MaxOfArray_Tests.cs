using Problems.ChatGPT.GPT0001MaxOfArray;

namespace Problems.Tests.ChatGPT;
[Trait("Kata", "GPT0001")]
public class GPT0001MaxOfArrayTests
{
    [Fact]
    public void SingleElementReturnsThatElement()
    {
        var result = Solution.FindMax(new[] { 7 });
        Assert.Equal(7, result);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, 4)]
    [InlineData(new int[] { 4, 3, 2, 1 }, 4)]
    [InlineData(new int[] { 0, -1, -2 }, 0)]
    [InlineData(new int[] { -10, -2, -30, -2 }, -2)]
    [InlineData(new int[] { -3, -3, -3 }, -3)]
    [InlineData(new int[] { 100, 100, 99 }, 100)]
    [InlineData(new int[] { int.MinValue, -1, 0 }, 0)]
    public void VariousArraysReturnsMax(int[] nums, int expected)
    {
        var result = Solution.FindMax(nums);
        Assert.Equal(expected, result);
    }
}
