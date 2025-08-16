namespace Problems.LeetCode.LC0013.RomanToInteger;
public class Solution
{
    public static int RomanToInt(string s)
    {
        int result = 0;
        bool skipNext = false;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (!skipNext)
            {
                switch (s[i])
                {
                    case 'I':
                        if (s[i + 1] == 'V')
                        {
                            result += 4;
                            skipNext = true;
                        }
                        else if (s[i + 1] == 'X')
                        {
                            result += 9;
                            skipNext = true;
                        }
                        else result += 1;
                        break;
                    case 'V':
                        result += 5;
                        break;
                    case 'X':
                        if (s[i + 1] == 'L')
                        {
                            result += 40;
                            skipNext = true;
                        }
                        else if (s[i + 1] == 'C')
                        {
                            result += 90;
                            skipNext = true;
                        }
                        else result += 10;
                        break;
                    case 'L':
                        result += 50;
                        break;
                    case 'C':
                        if (s[i + 1] == 'D')
                        {
                            result += 400;
                            skipNext = true;
                        }
                        else if (s[i + 1] == 'M')
                        {
                            result += 900;
                            skipNext = true;
                        }
                        else result += 100;
                        break;
                    case 'D':
                        result += 500;
                        break;
                    case 'M':
                        result += 1000;
                        break;
                }
            }
            else skipNext = false;
        }
        if (!skipNext)
        {
            switch (s[s.Length-1])
            {
                case 'I':
                    result += 1;
                    break;
                case 'V':
                    result += 5;
                    break;
                case 'X':
                    result += 10;
                    break;
                case 'L':
                    result += 50;
                    break;
                case 'C':
                    result += 100;
                    break;
                case 'D':
                    result += 500;
                    break;
                case 'M':
                    result += 1000;
                    break;
            }
        }
        return result;
    }
}