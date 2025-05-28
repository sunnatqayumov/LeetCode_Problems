public class Solution 
{
    public int AddDigits(int num) 
    {
        for(int i = 0; i < num; i++)
        {
            int a = 0;
            int b = 0;

            if(num >= 1 && num < 10)
            {
                return num;
            }
            else
            {
                a = num / 10;
                b = num % 10;
                num = a + b;
            }
        }
        return num;
    }
}