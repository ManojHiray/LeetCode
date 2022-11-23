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
    public bool HasPathSum(TreeNode root, int targetSum) 
    {
        if(root == null)
        {
            return false;
        }
        
        Stack<TreeNode> path = new Stack<TreeNode>();
        Stack<int>  sumPath = new Stack<int>();
        
        path.Push(root);
        sumPath.Push(root.val);
        
        while(path.Count != 0)
        {
            TreeNode temp = path.Pop();
            int tempVal = sumPath.Pop();
            
            if(temp.left == null && temp.right == null && tempVal == targetSum)
                return true;
            
            if(temp.right != null)
            {
                path.Push(temp.right);
                sumPath.Push(temp.right.val + tempVal);
            }
            
            if(temp.left != null)
            {
                path.Push(temp.left);
                sumPath.Push(temp.left.val + tempVal);
            }
        }
        return false;
    }
}