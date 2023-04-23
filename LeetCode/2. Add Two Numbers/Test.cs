using NUnit.Framework;

namespace LeetCodeAndCodewars.LeetCode.N2AddTwoNumbers;

public class Tests
{
    [Test]
    public void TestExample()
    {
        var obj = new Solve();
        
        // Assert.AreEqual
        // (
        //     CreateListNode(new List<int>() {7, 0, 8}), 
        //     obj.AddTwoNumbers
        //     (
        //         CreateListNode(new List<int>() {2, 4, 3}),
        //         CreateListNode(new List<int>() {5, 6, 4})
        //     ), 
        //     "Example 1"
        // );
        //
        // Assert.AreEqual
        // (
        // CreateListNode(new List<int>() {0}), 
        // obj.AddTwoNumbers
        // (
        //     CreateListNode(new List<int>() {0}),
        //     CreateListNode(new List<int>() {0})
        // ), 
        //     "Example 2"
        // );

        
        
        Assert.AreSame
        (
            CreateListNode(new List<int>() {8, 9, 9, 9, 0, 0, 0, 1}), 
            obj.AddTwoNumbers
            (
                CreateListNode(new List<int>() {9, 9, 9, 9, 9, 9, 9}),
                CreateListNode(new List<int>() {9, 9, 9, 9})
            ), 
            "Example 3"
        );
    }


    private Solve.ListNode CreateListNode(List<int> l) => Solve.ListNode.ToListNode(new List<int>() { 1, 2, 3 });
}