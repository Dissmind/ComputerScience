namespace Leetcode.N235LowestCommonAncestorofaBinarySearchTree;

public class Solve
{ 
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root.val > p.val && root.val > q.val)
        {
            LowestCommonAncestor(root.left, p, q);
        }
        else if (root.val > p.val && root.val > q.val)
        {
            LowestCommonAncestor(root.right, p, q);
        }
        else
        {
            return root;
        }

        return root;
    }
}