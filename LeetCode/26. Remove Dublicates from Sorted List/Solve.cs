namespace Leetcode._26._Remove_Dublicates_from_Sorted_List;

public class Solve
{
    public int RemoveDuplicates(int[] nums)
    {
        int counter = 1;
        int maxFoundNumber = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > maxFoundNumber)
            {
                maxFoundNumber = nums[i];
                nums[counter] = nums[i];
                counter++;
            }
        }
        
        return counter;
    }
}