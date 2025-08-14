namespace Problems.Custom.CUSTOM0001.CoinsChange;

public class Solution
{
    public static string CoinsChange(int[] nums, int sum)
    {
        List<int> coins = new List<int>();
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            while (sum >= nums[i])
            {
                    coins.Add(nums[i]);
                    sum -= nums[i];
                
            }
        }
        string result = (coins.Count == 0 || sum != 0) ? "No change" : string.Join(",", coins);
        return result;
    }
}