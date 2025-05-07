public class Solution 
{
    public string Multiply(string num1, string num2) 
    {
        BigInteger son1 = BigInteger.Parse(num1);
        BigInteger son2 = BigInteger.Parse(num2);

        BigInteger son3 = son1 * son2;

        return son3.ToString();
    }
}