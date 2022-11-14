/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution 
{
    public List<Integer> inorderTraversal(TreeNode root) 
    {
        List <Integer> result = new ArrayList<>();
        
        Stack <TreeNode> st = new Stack<>();
        
        while(!st.isEmpty() || root != null)
        {
            while(root != null)
            {
                st.push(root);
                root = root.left;
            }
            
            TreeNode temp = st.pop();
            
            result.add(temp.val);
            
            root = temp.right;
        }
        return result;
    }
}