using NUnit.Framework;

namespace LeetCodeAndCodewars.Codewars.GetTheMiddleCharacter;

public class Test
{
    [Test]
    public void GenericTests()
    {
        Assert.AreEqual("es",Kata.GetMiddle("test"));
        Assert.AreEqual("t",Kata.GetMiddle("testing"));
        Assert.AreEqual("dd",Kata.GetMiddle("middle"));
        Assert.AreEqual("A",Kata.GetMiddle("A"));
    }
}