namespace Problems.LeetCode.LC0001.TwoSum;
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (j == i) break;
                else if (nums[i] + nums[j] == target)
                {
                    result[0] = j;
                    result[1] = i;
                }
            }
        }
        return result;
    }
}