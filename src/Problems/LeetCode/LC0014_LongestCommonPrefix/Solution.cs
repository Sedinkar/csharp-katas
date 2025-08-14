namespace Problems.LeetCode.LC0014.LongestCommonPrefix;

public class Solution
{
    public static string LongestCommonPrefix(string[] strs)
    {
        string shortestWord = strs[0];
        int lowestLength = shortestWord.Length;
        string result = string.Empty;
        foreach (string word in strs)
        {
            if (word.Length < lowestLength)
            {
                lowestLength = word.Length;
                shortestWord = word;
            }
        }
        for (int i = 0; i < lowestLength; i++)
        {
            char c = shortestWord[i];
            foreach (string str in strs)
            {
                if (c != str[i]) return result;
            }
            result = result + shortestWord[i];

        }
        return result;
    }
}