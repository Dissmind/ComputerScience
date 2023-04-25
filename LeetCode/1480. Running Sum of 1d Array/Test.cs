using Leetcode.N1480RunningSumOf1DArray;
using NUnit.Framework;

public class Test
{
    [Test]
    public void TestExample()
    {
        var obj = new Solve();
        Assert.AreEqual(new int[] {1,3,6,10}, obj.RunningSum(new int[] {1,2,3,4}), "Test example 1");
        Assert.AreEqual(new int[] {1,2,3,4,5}, obj.RunningSum(new int[] {1,1,1,1,1}), "Test example 2");
        Assert.AreEqual(new int[] {3,4,6,16,17}, obj.RunningSum(new int[] {3,1,2,10,1}), "Test example 3");
    }
}