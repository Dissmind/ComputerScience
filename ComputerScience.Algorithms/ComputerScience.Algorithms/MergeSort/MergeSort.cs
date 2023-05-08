namespace ComputerScience.Algorithms.MergeSort;

public class MergeSort
{
    public static IComparable[] Sort<T>(IComparable[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }
    
        int middlePosition = array.Length / 2;
        
        IComparable[] leftArray = array.Take(middlePosition).ToArray();
        IComparable[] rightArray = array.Skip(middlePosition).ToArray();
        
        IComparable[] result = Merge<T>(Sort<T>(leftArray), Sort<T>(rightArray));
    
        return result;
    }
    
    
    private static IComparable[] Merge<T>(IComparable[] leftArray, IComparable[] rightArray)
    {
        int leftPtrIndex = 0;
        int rightPtrIndex = 0;
    
        int mergedArrayLength = leftArray.Length + rightArray.Length;
        IComparable[] mergedArray = new IComparable[mergedArrayLength];
    
        for (int i = 0; i < mergedArray.Length; i++)
        {
            if (leftPtrIndex < leftArray.Length && rightPtrIndex < rightArray.Length)
            {
                if (leftArray[leftPtrIndex].CompareTo(rightArray[rightPtrIndex]) > 0)
                {
                    mergedArray[i] = rightArray[rightPtrIndex];
                    rightPtrIndex++;
                }
                else
                {
                    mergedArray[i] = leftArray[leftPtrIndex];
                    leftPtrIndex++;
                }
            }
            else
            {
                if (rightPtrIndex < rightArray.Length)
                {
                    mergedArray[i] = rightArray[rightPtrIndex];
                    rightPtrIndex++;
                }
                else
                {
                    mergedArray[i] = leftArray[leftPtrIndex];
                    leftPtrIndex++;
                }
            }
        }
        
        return mergedArray;
    }
}