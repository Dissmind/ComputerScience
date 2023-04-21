using NUnit.Framework;

namespace LeetCodeAndCodewars.LeetCode.N1TwoSum;

public class Test
{
    [Test]
    public void TestExample()
    {
        var obj = new Solve();
        Assert.AreEqual(new int[] {0, 1}, obj.TwoSum(new int[] {2, 7, 11, 15}, 9), "Case 1");
        Assert.AreEqual(new int[] {1, 2}, obj.TwoSum(new int[] {3, 2, 4}, 6), "Case 2");
        Assert.AreEqual(new int[] {0, 1}, obj.TwoSum(new int[] {3, 3}, 6), "Case 3");
    }
}