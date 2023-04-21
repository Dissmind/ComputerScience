namespace LeetCodeAndCodewars.Codewars.GetTheMiddleCharacter;

public class Kata
{
    public static string GetMiddle(string s)
    {
        int evenCheck = s.Length % 2;
    
        int middleIndex = s.Length / 2;
        
        if (evenCheck == 1)
        {
            return s[middleIndex].ToString();
        }
    
        return s.Substring(middleIndex - 1, 2);
    }
    
    
    // Variant 2
    // public static string GetMiddle(string s) => string.IsNullOrEmpty(s)
    //     ? s
    //     : s.Substring((s.Length - 1) / 2, 2 - s.Length % 2);
}