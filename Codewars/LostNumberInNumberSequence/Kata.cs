using System.Linq;

namespace LeetCodeAndCodewars.Codewars.LostNumberInNumberSequence;

public class Kata
{
    public static int FindDeletedNumber(List<int> startingList, List<int> mixedList) =>
        startingList.Sum(i => i) - mixedList.Sum(i => i);
    
    
    // V2
    // public static int FindDeletedNumber(List<int> startingList, List<int> mixedList) =>
    //     startingList.Except(mixedList).FirstOrDefault();
}