public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        var tList = t.ToCharArray().ToList();
        var sList = s.ToCharArray();

        var result = 0;

        for (int i = 0; i < tList.Count; i++)
        {
            if(result < sList.Length && tList[i] == sList[result])
            {
                result++;
            }
        }
        if(result == sList.Length)
        {
            return true;
        }
        return false;
    }
}