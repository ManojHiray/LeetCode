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
    private bool result = true;
    
    public bool IsBalanced(TreeNode root) 
    {
            maxDepth(root);
            return result;

    }


    public int maxDepth(TreeNode root) 
    {
    
        if (root == null)
            return 0;
    
        int l = maxDepth(root.left);
    
        int r = maxDepth(root.right);
    
        if (Math.Abs(l - r) > 1)
            result = false;
        
        return 1 + Math.Max(l, r);
    }
}