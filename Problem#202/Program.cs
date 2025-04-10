public class Solution 
{
    public bool IsHappy(int n) 
    {
        List<int> list = new List<int>();
        int sum = 0;

        while(n != 1)
        {
            if (list.Contains(n)) 
                return false;

            list.Add(n);
            while (n > 0) 
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }
            n = sum;
        }
        return true;
    }
}