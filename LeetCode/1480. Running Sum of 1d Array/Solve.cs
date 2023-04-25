namespace Leetcode.N1480RunningSumOf1DArray;

public class Solve
{
    public int[] RunningSum(int[] nums)
    {
        int[] result = new int[nums.Length];
        
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                result[i] += nums[j];
            }
        }

        return result;
    }
}