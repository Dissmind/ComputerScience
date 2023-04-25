using NUnit.Framework;

namespace Leetcode.N724FindPivotIndex;

public class Test
{
    [Test]
    public void TestExample()
    {
        var obj = new Solve();
        Assert.AreEqual(3, obj.PivotIndex(new int[] {1,7,3,6,5,6}), "Example 1");
        Assert.AreEqual(-1, obj.PivotIndex(new int[] {1,2,3}), "Example 2");
        Assert.AreEqual(0, obj.PivotIndex(new int[] {2,1,-1}), "Example 3");
    }
}