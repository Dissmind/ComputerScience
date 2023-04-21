using NUnit.Framework;

namespace LeetCodeAndCodewars.Codewars.SimpleNumberSequence;


[TestFixture]
public class Test
{
    [Test]
    public void ExampleTests()
    {
        Assert.AreEqual((Int32)4,(Int32)Kata.missing("123567"));
        Assert.AreEqual((Int32)92,(Int32)Kata.missing("899091939495"));
        Assert.AreEqual((Int32)100,(Int32)Kata.missing("9899101102"));
        Assert.AreEqual((Int32)(-1), (Int32)Kata.missing("599600601602"));
        Assert.AreEqual((Int32)(-1),(Int32)Kata.missing("8990919395"));
        Assert.AreEqual((Int32)1002,(Int32)Kata.missing("998999100010011003"));
        Assert.AreEqual((Int32)10000,(Int32)Kata.missing("99991000110002"));
        Assert.AreEqual((Int32)(-1),(Int32)Kata.missing("979899100101102"));
        Assert.AreEqual((Int32)900003,(Int32)Kata.missing("900001900002900004900005900006"));
    }
}