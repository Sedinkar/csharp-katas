using Problems.Custom.CUSTOM0001.CoinsChange;

namespace Problems.Tests.ChatGPT;
[Trait("Kata", "CUSTOM0001")]
public class CUSTOM0001SolutionTests
{
    [Fact]
    public void SingleElementReturnsThatElement()
    {
        int[] test = new int[] { 1, 5, 10 };
        var result = Solution.CoinsChange(test,0);
        Assert.Equal("No change", result);
    }

    [Theory]
    [InlineData(new int[] { 1, 5, 10, 25, 100 }, 4, "1,1,1,1")]
    [InlineData(new int[] { 1, 5, 10, 25, 100 }, 333, "100,100,100,25,5,1,1,1")]
    [InlineData(new int[] { 1, 5, 10, 25, 100 }, 150, "100,25,25")]
    [InlineData(new int[] { 1, 5, 10, 25, 100 }, 17, "10,5,1,1")]
    [InlineData(new int[] { 2, 4 }, 1, "No change")]
    [InlineData(new int[] { 1, 3, 4 }, 6, "4,1,1")]
    [InlineData(new int[] { 3, 5, 7 }, 14, "7,7")]
    [InlineData(new int[] { 2, 4, 5 }, 9, "5,4")]
    public void VariousArraysReturnsResults(int[] nums, int sum, string expected)
    {
        var result = Solution.CoinsChange(nums, sum);
        Assert.Equal(expected, result);
    }
}
