public class Solution 
{
    public int SingleNumber(int[] nums)
    {
        return nums.Distinct().First(x => nums.Count(n => n == x) == 1);  
    }
}