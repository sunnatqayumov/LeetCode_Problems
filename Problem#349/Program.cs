public class Solution 
{
    public int[] Intersection(int[] nums1, int[] nums2) 
    {
        var list1 = new List<int>();
        var list2 = new List<int>();
        var result = new List<int>();

        foreach (var num in nums1)
        {
            if (!list1.Contains(num))
                list1.Add(num);
        }
        foreach (var num in nums2)
        {
            if (!list2.Contains(num)) 
                list2.Add(num);
        }
        foreach (var num in list1)
        {
            if (list2.Contains(num))
                result.Add(num);
        }
        return result.ToArray();
    }
}