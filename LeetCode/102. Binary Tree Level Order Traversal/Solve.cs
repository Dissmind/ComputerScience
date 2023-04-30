namespace Leetcode.N102BinaryTreeLevelOrderTraversal;

public class Solve
{
    public class TreeNode { 
        public int val;
        public TreeNode left;
        public TreeNode right;
        
        
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) { 
            this.val = val; 
            this.left = left; 
            this.right = right;
        }
    }
 
    private IList<IList<int>> result = new List<IList<int>>();
    
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        Recurse(root, 0);

        return result;
    }

    private void Recurse(TreeNode root, int depth)
    {
        if(root == null)
        {
            return;
        }
        
        if(result.Count == depth)
        {
            result.Add(new List<int>());
        }
        
        result[depth].Add(root.val);
        
        Recurse(root.left, depth+1);
        Recurse(root.right, depth+1);
    }
}