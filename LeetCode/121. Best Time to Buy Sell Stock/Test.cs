using NUnit.Framework;

namespace Leetcode.N121BestTimeToBuySellStock;

public class Test
{
    [Test]
    public void ExampleTest()
    {
        var obj = new Solve();
        Assert.AreEqual(5, obj.MaxProfit(new int[] {7,1,5,3,6,4}), "Example 1");
        Assert.AreEqual(0, obj.MaxProfit(new int[] {7,6,4,3,1}), "Example 2");
    }
}