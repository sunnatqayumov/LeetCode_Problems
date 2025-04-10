public class Solution 
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        if (nums1.Length > nums2.Length) 
        {
            return FindMedianSortedArrays(nums2, nums1); // Make sure nums1 is the smaller array
        }
        int m = nums1.Length, n = nums2.Length;
        int low = 0, high = m;

        while (low <= high) 
        {
            int partition1 = (low + high) / 2;
            int partition2 = (m + n + 1) / 2 - partition1;

            // Get the left and right elements around the partition
            int maxLeft1 = (partition1 == 0) ? int.MinValue : nums1[partition1 - 1];
            int minRight1 = (partition1 == m) ? int.MaxValue : nums1[partition1];

            int maxLeft2 = (partition2 == 0) ? int.MinValue : nums2[partition2 - 1];
            int minRight2 = (partition2 == n) ? int.MaxValue : nums2[partition2];

            // Check if we have found the correct partition
            if (maxLeft1 <= minRight2 && maxLeft2 <= minRight1) 
            {
                // If the combined length is odd, the median is the maximum of the left elements
                if ((m + n) % 2 == 1) 
                {
                    return Math.Max(maxLeft1, maxLeft2);
                } 
                else 
                {
                    // If the combined length is even, the median is the average of the two middle values
                    return (Math.Max(maxLeft1, maxLeft2) + Math.Min(minRight1, minRight2)) / 2.0;
                }
            } 
            else if (maxLeft1 > minRight2) 
            {
                // We need to move the partition in nums1 to the left
                high = partition1 - 1;
            } 
            else 
            {
                // We need to move the partition in nums1 to the right
                low = partition1 + 1;
            }
        }
        throw new ArgumentException();
    }
}