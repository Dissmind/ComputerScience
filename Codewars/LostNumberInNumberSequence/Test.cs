using NUnit.Framework;

namespace LeetCodeAndCodewars.Codewars.LostNumberInNumberSequence;

[TestFixture]
public class Test
{
    [Test]
    public void MissingNumberTest()
    {
        Assert.AreEqual((Int32)6, (Int32)Kata.FindDeletedNumber(new List<int>(){1,2,3,4,5,6,7,8,9}, new List<int>(){5,7,1,9,4,8,2,3}));
        Assert.AreEqual((Int32)1, (Int32)Kata.FindDeletedNumber(new List<int>(){1}, new List<int>()));
    }
    
    [Test]
    public void NoMissingNumberTest()
    {
        Assert.AreEqual((Int32)0, (Int32)Kata.FindDeletedNumber(new List<int>(){1,2,3,4,5,6,7}, new List<int>(){2,3,6,1,5,4,7}));
        Assert.AreEqual((Int32)0, (Int32)Kata.FindDeletedNumber(new List<int>(){1,2,3,4,5,6,7,8,9}, new List<int>(){5,7,6,9,4,8,1,2,3}));
    }
    
    [Test]
    public void NilTest()
    {
        Assert.AreEqual((Int32)0, (Int32)Kata.FindDeletedNumber(new List<int>(), new List<int>()));
    }
}