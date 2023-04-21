namespace LeetCodeAndCodewars.Codewars.BinartAddition;

public class Kata
{
    public static string AddBinary(int a, int b) =>
        Convert.ToString(a + b, 2);
    
    
    // Variant 2
    // public static string AddBinary(int a, int b)
    // {
    //     int sum = a + b;
    //
    //     string result = DecimalToBinary(sum);
    //
    //     return "1";
    // }
    //
    //
    // private static string DecimalToBinary(int decimalNumber)
    // {
    //     string binaryNumber = "";
    //
    //     while (decimalNumber > 0)
    //     {
    //         binaryNumber = (decimalNumber % 2) + binaryNumber;
    //         decimalNumber /= 2;
    //     }
    //
    //     return binaryNumber;
    // }
}