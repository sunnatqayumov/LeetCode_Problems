public class Solution
 {
    public bool IsValid(string s) 
    {
        char[] stack = new char[s.Length];  
        int index = 0;

        foreach (char c in s) 
        {
            if (c == '(' || c == '{' || c == '[') 
            {
                stack[index++] = c;  
            } 
            else
            {
                if (index == 0) 
                    return false;  

                char top = stack[--index];  
                
                if ((c == ')' && top != '(') || 
                    (c == '}' && top != '{') || 
                    (c == ']' && top != '[')) {
                    return false;
                }
            }
        }
        return index == 0;  
    }
}