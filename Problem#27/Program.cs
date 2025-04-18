﻿public class Solution 
{
    public int RemoveElement(int[] nums, int val) 
    {
        var lastIndex = nums.Length - 1;

        for (int i = 0; i <= lastIndex; i++)
        {
            if (nums[i] == val)
            {
                nums[i--] = nums[lastIndex--];
            }
        }
        return lastIndex + 1;
    }
}