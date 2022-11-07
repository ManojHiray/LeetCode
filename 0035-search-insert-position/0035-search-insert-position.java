class Solution 
{
    public int searchInsert(int[] nums, int target) //target = 2   [1,3,5,6]
    {
        
        int low = 0; 
        int high = nums.length-1; //4
        
            //0 < 4
            //0 < 1
       while(low <= high)
       {
           //         0       4-0
           //         0       1
           int mid = low + (high - low) / 2;
           //2  2
           
                //5  F 2
                //
           if(nums[mid] == target)
           {
               return mid;
           }
                //  5  T  2
           else if(nums[mid] > target)
           {
               high = mid - 1;
                     //2-1=1 //return insert position 
           }
           else
           {
               low = mid + 1; 
           }
       }
       return low; 
      
    }
}

//Using Binary Search