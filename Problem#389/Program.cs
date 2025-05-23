public class Solution
{
    public char FindTheDifference(string s, string t)
    {

        var sList = s.ToCharArray();
        var tList = t.ToCharArray();

        Array.Sort(sList);
        Array.Sort(tList);

        for (int i = 0; i < sList.Length; i++)
        {
            if (sList[i] != tList[i])
                return tList[i];
        }
        return tList[tList.Length - 1];
    }
}