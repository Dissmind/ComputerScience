namespace ComputerScience.Algorithms.MultiplicationColumn;

public class MultiplicationColumn
{
    public static void SolvingAndDisplayConsole(int x, int y)
    {
        Result result = Solving(x, y);
        Display(x, y, result);
    }
    
    
    
    public struct Result
    {
        public Result()
        {
            Value = 0;
            StepResultArray = new int[] { };
        }
        
        
        public int Value;
        public int[] StepResultArray;
    }
    
    
    
    public static Result Solving(int x, int y)
    {
        char[] yCharArray = y.ToString().ToCharArray();
        yCharArray = yCharArray.Reverse().ToArray();

        int[] stepResultArray = new int[yCharArray.Length]; 
        
        for (int i = 0; i < yCharArray.Length; i++)
        {
            int number = Int32.Parse(yCharArray[i].ToString());

            int stepResult = x * number;

            if (i != 0)
            {
                stepResult *= (int)(Math.Pow(10, i));
            }

            stepResultArray[i] = stepResult;
        }
        
        Result result = new Result
        {
            StepResultArray = stepResultArray,
            Value = stepResultArray.Sum()
        };

        return result;
    }

    

    #region ConsoleUI

    /*
     * Input Example:
     *       5678
     *     * 1234
     *  -----------
     *      22712
     *     17034 
     *    11346  
     *   5678    
     * -----------
     *   7006652

     * 
     */
    public static void Display(int x, int y, Result result)
    {
        int maxSpaces = result.Value.ToString().Length + 4;
        
        string separatorsStr = RepeatStr("-", maxSpaces);

        Console.WriteLine(MarginStr(x.ToString(), maxSpaces));
        Console.WriteLine(MarginStr("* " + y, maxSpaces));
        Console.WriteLine(separatorsStr);

        for (int i = 0; i < result.StepResultArray.Length; i++)
        {
            Console.WriteLine(MarginForStepResults(result.StepResultArray[i], i, maxSpaces));
        }

        Console.WriteLine(separatorsStr);
        Console.WriteLine(MarginStr(result.Value.ToString(), maxSpaces));
    }

    private static string RepeatStr(string str, int count)
    {
        string result = "";
        
        for (int i = 1; i <= count; i++)
        {
            result += str;
        }

        return result;
    }

    private static string MarginStr(string str, int maxSpace)
    {
        string marginRightStr = "  ";

        int marginLeftCount = maxSpace - str.Length;
        string marginLeftStr = RepeatStr(" ", marginLeftCount);

        string result = marginLeftStr + str + marginRightStr;

        return result;
    }

    private static string MarginForStepResults(int result, int index, int maxSpace)
    {
        string resultStr = result.ToString();
        
        resultStr = resultStr.Substring(0, resultStr.Length - index);
        resultStr += RepeatStr(" ", index);
        resultStr = MarginStr(resultStr, maxSpace);
        
        return resultStr;
    }

    #endregion
}