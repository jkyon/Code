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
public class Solution 
{
    private int totalSum = 0;

    private int maxLevel = -1;

    public int DeepestLeavesSum(TreeNode root) 
    {
        Travel(root, 1);
        return totalSum;
    }

    private void Travel(TreeNode node, int level)
    {
        if(node == null)
        {
            return;
        }

        if(node.left == null && node.right == null)
        {
            if(level > maxLevel)
            {
                maxLevel = level;
                totalSum = node.val;
            }
            else if(maxLevel == level)
            {
                totalSum = totalSum + node.val;
            }
        }

        level++;
        Travel(node.left, level);

        Travel(node.right, level);
    }


}