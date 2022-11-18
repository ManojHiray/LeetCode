public class Solution 
{
    public int[] GetConcatenation(int[] nums) 
    {
        int iNo = nums.Length;
        
        int[] iAns = new int[2 * iNo];
        
        for(int i = 0; i < iNo; i++)
        {
            iAns[i] = nums[i];
            iAns [i + iNo] = nums[i];
        }
        
        return iAns;
    }
}