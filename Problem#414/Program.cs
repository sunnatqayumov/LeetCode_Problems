public class Solution 
{
    public int ThirdMax(int[] nums) 
    {
        var result = nums.Distinct().OrderByDescending(n => n).ToList();

        if(result.Count < 3)
        {
            return result[0];
        }
        return result[2];
    }
}