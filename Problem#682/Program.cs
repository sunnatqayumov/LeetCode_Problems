public class Solution 
{
    public int CalPoints(string[] operations) 
    {
        List<int> scores = new List<int>();

        for (int i = 0; i < operations.Length; i++) 
        {
            if (operations[i] == "C") 
            {
                if (scores.Count > 0) 
                    scores.RemoveAt(scores.Count - 1);
            } 
            else if (operations[i] == "D") 
            {
                if (scores.Count > 0)
                    scores.Add(scores[scores.Count - 1] * 2);
            } 
            else if (operations[i] == "+") 
            {
                if (scores.Count > 1)
                    scores.Add(scores[scores.Count - 1] + scores[scores.Count - 2]);
            } 
            else 
            {
                scores.Add(int.Parse(operations[i]));
            }
        }
        return scores.Sum();
    }
}