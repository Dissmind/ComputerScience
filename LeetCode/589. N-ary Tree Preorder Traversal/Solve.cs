namespace Leetcode.N589NaryTreePreorderTraversal;

public class Solve
{
    public class Node {
        public int val;
        public IList<Node> children;

        public Node() {}

        public Node(int _val) {
            val = _val;
        }

        public Node(int _val,IList<Node> _children) {
            val = _val;
            children = _children;
        }
    }
    
    
    public IList<int> Preorder(Node root)
    {
        List<int> result = new List<int>();
        if(root==null) return result;

        Stack<Node> st = new();

        st.Push(root);
        while(st.Count>0)
        {
            Node top = st.Pop();
            result.Add(top.val);

            for(int i = top.children.Count-1;i>=0;i--)
            {
                st.Push(top.children[i]);
            }
        }

        return result;



        // var result = new List<int>();
        //
        // if (root == null)
        // {
        //     return result;
        // }
        //
        // Stack<Node> stack = new Stack<Node>();
        // stack.Push(root);
        //
        // while (stack.Count > 0)
        // {
        //     Node node = stack.Pop();
        //     
        //     result.Add(node.val);
        //
        //     if (node.children != null)
        //     {
        //         for (int i = node.children.Count - 1; i >= 0; i--)
        //         {
        //             stack.Push(node.children[i]);
        //         }
        //     }
        // }
        //
        // return result;
    }
}