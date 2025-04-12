namespace Code;

public class HasPathSumSolution 
{
    private int targetSumValue = 0;
    private bool found = false;
    public bool HasPathSum(TreeNode root, int targetSum) 
    {
        targetSumValue = targetSum;
        Travel(root, root?.val ?? 0);
        return found;
    }

    private void Travel(TreeNode node, int currentSum)
    {
        if(node == null)
        {
            return;
        }

        if(found)
        {
            return;
        }

    
        if(node.left == null && node.right == null)
        {
            if(targetSumValue == currentSum)
            {
                found = true;
            }
        }

        Travel(node.left, currentSum + node.left?.val ?? 0);

        Travel(node.right, currentSum + node.right?.val ?? 0);
    }
    
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) 
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}