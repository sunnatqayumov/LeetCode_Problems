public class Solution
{
    public int LengthOfLongestSubstring(string str)
    {
        string Substring = "";
        int maxLength = 0;

        foreach(char c in str)
        {
            if(Substring.Contains(c))
            {
                int index = Substring.IndexOf(c);
                Substring = Substring.Substring(index + 1);
            }
            Substring += c;

            maxLength = Math.Max(maxLength, Substring.Length);
        }
        return maxLength;
    }
}