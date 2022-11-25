public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
       if(prices == null || prices.Length <= 1)
           return 0;
        
        int n = prices.Length;
        int buy = prices[0];
        int sell = 0;
        int maxPro = 0;
        
        for(int i=1; i<n; i++)
        {
            sell = Math.Max(sell, prices[i]-buy);
            buy = Math.Min(buy, prices[i]);
            maxPro = Math.Max(maxPro, sell);
        }
        return maxPro;
    }
}