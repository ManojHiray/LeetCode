class Solution {
    public int removeDuplicates(int[] nums) {
        
        if(nums.length == 0)
        {
            return 0;
        }
        
        int i = 0;
        int j = 0;
                
                    //1<3
                    //2<3
                    //3<3 F
        for(j=1; j < nums.length; j++)//2,3
        {
            //inplace sorting 
                //1     T     1
                //2      F     1
            if(nums[j] != nums[i])
            {
                i++; //1
                
                nums[i] = nums[j];
                        //= 1
            }
        }
        return i+1;//1+1=2
    }
}
//0 1 2
//[1,1,2]