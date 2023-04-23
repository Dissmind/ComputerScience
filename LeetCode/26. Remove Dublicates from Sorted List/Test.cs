using NUnit.Framework;

namespace Leetcode.N26RemoveDublicatesFromSortedList;

public class Test
{
    [Test]
    public void TestExample()
    {
        var obj = new Solve();
        Assert.AreEqual(2, obj.RemoveDuplicates(new int[] {1,1,2}), "Case 1");
        Assert.AreEqual(5, obj.RemoveDuplicates(new int[] {0,0,1,1,1,2,2,3,3,4}), "Case 2");
    }
}