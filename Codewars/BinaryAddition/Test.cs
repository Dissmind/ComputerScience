using NUnit.Framework;

namespace LeetCodeAndCodewars.Codewars.BinartAddition;

public class Test
{
    [Test]
    public void TestExample()
    {
        Assert.AreEqual("11", Kata.AddBinary(1, 2), "Should return \"11\" for 1 + 2");
    }
}