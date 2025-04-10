public class Solution 
{
    public string LongestCommonPrefix(string[] strs) 
    {
        if (strs == null)
            return "";

        Array.Sort(strs);

        string harf = strs[0];

        string s = strs[strs.Length - 1];

        int i = 0;

        while(i < harf.Length && i < s.Length && harf[i] == s[i])
        {
            i++;
        }
        return harf.Substring(0, i);
    }
}