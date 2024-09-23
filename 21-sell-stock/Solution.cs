namespace _21_sell_stock
{
    //https://leetcode.com/problems/best-time-to-buy-and-sell-stock/?envType=study-plan-v2&envId=top-interview-150
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            var result = 0;
            var lowest = prices[0];

            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] > prices[i + 1] && lowest > prices[i + 1])
                {
                    lowest = prices[i + 1];
                }
                var temp = prices[i + 1] - lowest;
                if (prices[i] < prices[i + 1] && result < temp)
                {
                    result = temp;
                }
            }
            return result;
        }
    }
}
