using System.Collections;

namespace LeetCodeAndCodewars.LeetCode.N1TwoSum;

public class Solve
{
    public int[] TwoSum(int[] nums, int target)
    {
        List<int> list = new List<int>()
        {
            nums[0]
        };

        int[] result = null;
        
        for (int i = 1; i < nums.Length; i++)
        {
            int needNumber = target - nums[i];
            
            if (list.Contains(needNumber))
            {
                int needNumbersIndex = list.FindIndex(i => i.Equals(needNumber));
                
                result = new int[2]
                {
                    needNumbersIndex,
                    i
                };             
                break;    
            }

            list.Add(nums[i]);
        }

        return result;
    }
}