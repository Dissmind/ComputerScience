namespace LeetCodeAndCodewars.Codewars.SimpleNumberSequence;


public class Kata
{
    public static int missing(string s)
    {
        //..
        int numberLength = NumberLength(s);
        int firstNumber = Int32.Parse(s.Substring(0, numberLength));

        while (true)
        {
            int expectedNextValue = firstNumber + 1;
        }


        return 1;
    }


    public static int NumberLength(string str)
    {
        int maxNumberLength = Int32.MaxValue.ToString().Length;

        for (int i = 1; i < maxNumberLength; i++)
        {
            int firstNumber = Int32.Parse(str.Substring(0, i));
            int secondNumber = Int32.Parse(str.Substring(i, i));
            
            if ((firstNumber + 1) == secondNumber) 
            {
                return i;
            }
        }
        
        
        throw new Exception("Not correct format");
    }
}



