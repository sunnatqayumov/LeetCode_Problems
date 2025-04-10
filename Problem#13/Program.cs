public class Solution
{
    public int RomanToInt(string str)
    {
        int total = 0;
        int result = 0;

        for(int i = str.Length - 1; i >= 0; i--)
        {
            char currentChar = str[i];
            int currentValue = 0;

            switch(currentChar)
            {
                case 'I':
                    currentValue = 1;
                break;

                case 'V':
                    currentValue = 5;
                break;

                case 'X':
                    currentValue = 10;
                break;

                case 'L':
                    currentValue = 50;
                break;

                case 'C':
                    currentValue = 100;
                break;

                case 'D':
                    currentValue = 500;
                break;

                case 'M':
                    currentValue = 1000;
                break;

                default:
                    currentValue = 0;
                break;
            }

            if(currentValue < result)
            {
                total -= currentValue;
            }
            else
            {
                total += currentValue;
            }
            result = currentValue;
        }
        return total;
    }
}