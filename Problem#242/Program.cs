public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var sList = s.ToCharArray();
        var tList = t.ToCharArray();

        Array.Sort(sList);
        Array.Sort(tList);

        for (int i = 0; i < sList.Length; i++)
        {
            if (sList[i] != tList[i])
                return false;
        }
        return true;
    }
}