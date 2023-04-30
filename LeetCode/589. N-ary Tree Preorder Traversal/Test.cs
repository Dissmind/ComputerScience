using NUnit.Framework;

namespace Leetcode.N589NaryTreePreorderTraversal;

public class Test
{
    private readonly Solve solve = new Solve();
    
    
    
    [Test]
    public void ExampleTest()
    {
        var tree1 = new Solve.Node(1, new List<Solve.Node>()
        {
            new Solve.Node(2),
            new Solve.Node(3, new List<Solve.Node>()
            {
                new Solve.Node(5),
                new Solve.Node(6)
            }),
            new Solve.Node(4),
        });
        Assert.AreEqual(new List<int>() {1,3,5,6,2,4}, solve.Preorder(tree1).ToList(), "Example 1");

        var tree2 = new Solve.Node(1, new List<Solve.Node>()
        {
            new Solve.Node(3, new List<Solve.Node>()
            {
                new Solve.Node(6),
                new Solve.Node(7, new List<Solve.Node>()
                {
                    new Solve.Node(11, new List<Solve.Node>()
                    {
                        new Solve.Node(14)
                    })
                })
            }),
            new Solve.Node(2),
            new Solve.Node(4, new List<Solve.Node>()
            {
                new Solve.Node(8, new List<Solve.Node>()
                {
                    new Solve.Node(12)
                })
            }),
            new Solve.Node(5, new List<Solve.Node>()
            {
                new Solve.Node(9, new List<Solve.Node>(13)),
                new Solve.Node(10)
            }),
        });
        
        Assert.AreEqual(new List<int>() {1,2,3,6,7,11,14,4,8,12,5,9,13,10}, solve.Preorder(tree2), "Example 2");
    }
}