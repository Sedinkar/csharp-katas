namespace Problems.LeetCode.LC0020.ValidParentheses;

public class Solution
{
    public static bool IsValid(string s)
    {
        bool result;
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case ')':
                    if (stack.Count > 0 && stack.Peek() == '(') stack.Pop();
                    else return false;
                        break;
                case ']':
                    if (stack.Count > 0 && stack.Peek() == '[') stack.Pop();
                    else return false;
                    break;
                case '}':
                    if (stack.Count > 0 && stack.Peek() == '{') stack.Pop();
                    else return false;
                    break;
                default:
                    if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                    stack.Push(s[i]);
                    else return false;
                    break;
            }
        }
        if (stack.Count == 0) result = true;
        else result = false;
        return result;
    }
}