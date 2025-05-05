public class Solution
{
    public int Rob(int[] nums)
    {
        int a = 0, b = 0;

        if(nums.Length == 0)
            return 0;

        if(nums.Length == 1)
            return nums[0];

        foreach(int num in nums)
        {
            int temp = a;
            a = Math.Max(b + num, a);
            b = temp;
        }
        return a;
    }
}