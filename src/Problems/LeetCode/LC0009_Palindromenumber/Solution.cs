namespace Problems.LeetCode.LC0009.PalindromeNumber;

public class Solution
{    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        int num = x;
        int reverseNum = 0;
        while (x != 0)
        {
            int digit = x % 10;
            reverseNum *= 10;
            reverseNum += digit;
            x /= 10;
        }
        return reverseNum == num;
    }
}
