public class Solution
{
    public void ReverseString(char[] s) 
    {
        char[] reversed = s.Reverse().ToArray();

        for (int i = 0; i < s.Length; i++) 
        {
            s[i] = reversed[i];
        }
    }
}