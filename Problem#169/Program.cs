public class Solution 
{
    public int MajorityElement(int[] nums) 
    {
        int count = 0;
        int son = 0;

        foreach (int num in nums) 
        {
            if (count == 0) 
            {
                son = num;
            }
            count += (num == son) ? 1 : -1;
        }
        return son;
    }
}