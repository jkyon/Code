/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) 
    {
        var result = Travel(p,q);
        return result;
    }

    bool Travel(TreeNode p, TreeNode q)
    {
        if(p == null && q == null)
        {
            return true;
        }
        
        if(p?.val == q?.val)
        {
            var r1 = Travel(p.left, q.left);

            var r2 = Travel(p.right, q.right);

            return r1 && r2;
        }
        
        return false;
    }
}