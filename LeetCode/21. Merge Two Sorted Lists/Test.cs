using NUnit.Framework;

namespace Leetcode.N21MergeTwoSortedLists;

public class Test
{
    private readonly Solve solve = new Solve(); 
    
    
    
    [Test]
    public void ExampleTest()
    {
        Assert.AreEqual
        (
            new Solve.ListNode(new List<int>()), 
            solve.MergeTwoLists
            (
                new Solve.ListNode(new List<int>()), 
                new Solve.ListNode(new List<int>())
            ), 
            "Example 1"
        );    
        Assert.AreEqual("0", solve.MergeTwoLists(new Solve.ListNode(new List<int>()), new Solve.ListNode(new List<int>() {0})), "Example 2");    
    }
}