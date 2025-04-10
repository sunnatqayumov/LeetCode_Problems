public class Solution 
{
    public string[] FindWords(string[] words) 
    {
        string row1 = "qwertyuiopQWERTYUIOP";
        string row2 = "asdfghjklASDFGHJKL";
        string row3 = "zxcvbnmZXCVBNM";
        List<string> list = new List<string>();
        foreach (var word in words)
        {
            int r1 = 0;
            int r2 = 0;
            int r3 = 0;

            for (int i=0; i<word.Length; i++)
            {
                if (row1.Contains(word[i]))
                {
                    r1 = 1;
                }
                if (row2.Contains(word[i]))
                {
                    r2 = 1;
                }
                if (row3.Contains(word[i]))
                {
                    r3 = 1;
                }
            }
            if(r1 + r2 + r3 == 1)
            {
                list.Add(word);
            }
           
        }
        return list.ToArray();
    }
}