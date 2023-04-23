namespace Leetcode.N14LongestCommonPrefix;

public class Solve
{
    public string LongestCommonPrefix(string[] strs)
    {
        string prefix = "";

        try
        {
            for (int i = 0; i < strs[0].Length; i++)
            {
                if (strs[0][i] == strs[1][i] && strs[0][i] == strs[2][i])
                {
                    prefix += strs[0][i];
                }
                else
                {
                    break;
                }
            }
        }
        catch (IndexOutOfRangeException e)
        {
            // prefix is done
        }
        
        
        return prefix;
    }
}