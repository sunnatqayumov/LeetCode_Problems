using System;

public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        if (n <= 0)
            return false;

        while (n % 2 == 0)
        {
            n /= 2;
        }
        if (n == 1)
            return true;
        else
            return false;
    }
}