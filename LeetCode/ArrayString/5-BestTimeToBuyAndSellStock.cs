using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
    public class BestBuySell
    {
        public int MaxProfit(int[] prices)
        {
            int lowestPrice = prices[0];
            int largestDifference = 0;

            for (int sellDay = 0; sellDay < prices.Length; sellDay++)
            {
                for (int buyDay = sellDay + 1; buyDay < prices.Length; buyDay++)
                {
                    if (prices[buyDay] < lowestPrice)
                    {
                        lowestPrice = prices[buyDay];
                    }
                }
                if (prices[sellDay] > lowestPrice)
                {
                    largestDifference = prices[sellDay] - lowestPrice;
                }
            }
            return largestDifference;
        }
    }
}
