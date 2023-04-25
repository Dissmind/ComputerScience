namespace Leetcode.N724FindPivotIndex;

public class Solve
{
    public int PivotIndex(int[] nums)
    {
        int sum = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }


        int leftSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (sum - nums[i] == leftSum * 2)
            {
                return i;
            }

            leftSum += nums[i];
        }
        
        return -1;
    }
}