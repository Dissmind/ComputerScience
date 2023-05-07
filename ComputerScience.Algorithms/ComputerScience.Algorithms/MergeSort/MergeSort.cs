using System.Reflection;

namespace ComputerScience.Algorithms.MergeSort;

public class MergeSort
{
    public static int[] Sort(int[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }
    
        int middlePosition = array.Length / 2;
        
        int[] leftArray = array.Take(middlePosition).ToArray();
        int[] rightArray = array.Skip(middlePosition).ToArray();
        
        int[] result = Merge(Sort(leftArray), Sort(rightArray));
    
        return result;
    }
    
    
    
    private static int[] Merge(int[] leftArray, int[] rightArray)
    {
        int leftPtrIndex = 0;
        int rightPtrIndex = 0;
    
        int mergedArrayLength = leftArray.Length + rightArray.Length;
        int[] mergedArray = new int[mergedArrayLength];
    
        for (int i = 0; i < mergedArray.Length; i++)
        {
            if (leftPtrIndex < leftArray.Length && rightPtrIndex < rightArray.Length)
            {
                if (leftArray[leftPtrIndex] > rightArray[rightPtrIndex])
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