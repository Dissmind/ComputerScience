namespace ComputerScience.Algorithms.MergeSort.UnitTest;

public class MergeSortMapping : MergeSort
{
    public static int[] Sort<T>(int[] array)
    {
        IComparable[] comparableArray = ArrayToComparable(array);
        IComparable[] sortedArray = Sort<int>(comparableArray);
        
        return ComparableToArray(sortedArray);
    }

    private static int[] ComparableToArray(IComparable[] array)
        => array.Select(i => (int)i).ToArray();

    
    private static IComparable[] ArrayToComparable(int[] array)
    {
        IComparable[] comparableArray = new IComparable[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            comparableArray[i] = array[i];
        }

        return (IComparable[])comparableArray;
    }
}