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
                if (CheckArrayItemEquals(strs, i))
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


    private bool CheckArrayItemEquals(string[] strs, int index)
    {
        char firstValue = strs[0][index];
        
        for (int i = 1; i < strs.Length; i++)
        {
            if (firstValue != strs[i][index])
            {
                return false;
            }
        }

        return true;
    }
}