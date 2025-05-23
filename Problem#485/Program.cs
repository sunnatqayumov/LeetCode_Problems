public class Solution 
{
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int count = 0, result = 0;

        foreach (var num in nums)
        {
            if(num == 0)
            {
                result = Math.Max(result, count);
                count = 0;
            }
            else
                count++;
        }
        return Math.Max(result, count);
    }
}