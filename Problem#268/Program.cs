public class Solution 
{
    public int MissingNumber(int[] nums) 
    {
        int result = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            result += (i + 1) - nums[i];
        }
        return result;
    }
}