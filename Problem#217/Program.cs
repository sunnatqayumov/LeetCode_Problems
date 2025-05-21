public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        List<int> result = [];

        foreach(var num in nums)
        {
            if(result.Contains(num))
                return true;

            result.Add(num);
        }
        return false;
    }
}