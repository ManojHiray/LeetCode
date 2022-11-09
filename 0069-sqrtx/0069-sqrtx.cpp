class Solution 
{
public:
    int mySqrt(int x) 
    {
        long long iStart = 0, iEnd = INT_MAX, iAns = 0;
        
        while(iStart <= iEnd)
        {
            long long iMid = iStart + (iEnd - iStart) / 2;
            
            if(iMid * iMid <= x)
            {
                iAns = iMid;
                iStart = iMid + 1;
            }
            else
            {
                iEnd = iMid - 1;
            }
        }
        return iAns;
    }
};