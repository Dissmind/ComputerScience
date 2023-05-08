using NUnit.Framework;

namespace ComputerScience.Algorithms.MergeSort.UnitTest;

public class UnitTests
{
    [Test]
    public static void Test()
    {
        Assert.AreEqual
        (
            new [] {1, 2, 3, 4, 5}, 
            MergeSortMapping.Sort<int>(new []{4, 3, 2, 1, 5}), 
            "1"
        );
        
        Assert.AreEqual
        (
            new [] {1, 2, 3, 4, 5, 6, 7, 8}, 
            MergeSortMapping.Sort<int>(new [] {5, 4, 1, 8, 7, 2, 6, 3}), 
            "2"
        );
    }
}