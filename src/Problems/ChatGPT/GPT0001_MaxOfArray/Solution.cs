namespace Problems.ChatGPT.GPT0001MaxOfArray;

public static class Solution
{
    /// <summary>
    /// Возвращает максимальный элемент массива.
    /// </summary>
    public static int FindMax(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        if (nums.Length == 0) throw new ArgumentException("Array must have at least one element.", nameof(nums));

        var max = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > max) max = nums[i];
        }
        return max;
    }
}
