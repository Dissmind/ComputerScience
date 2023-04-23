using NUnit.Framework;

namespace Leetcode.N14LongestCommonPrefix;

public class Test
{
    [Test]
    public void TestExample()
    {
        var obj = new Solve();
        Assert.AreEqual("fl", obj.LongestCommonPrefix(new string[] {"flower", "flow", "flight"}), "Example 1");
        Assert.AreEqual("", obj.LongestCommonPrefix(new string[] {"dog", "rececar", "car"}), "Example 2");
    }
}