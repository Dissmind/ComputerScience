namespace Leetcode.N121BestTimeToBuySellStock;

public class Solve
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        
        for (int i = 0; i < prices.Length - 1; i++)
        {
            int costPrice = prices[i];
            int maxSellPrice = MaxArray(i + 1, prices);

            int profit = maxSellPrice - costPrice;

            if (maxProfit < profit)
            {
                maxProfit = profit;
            }
        }

        return maxProfit;
    }


    private int indexMaxValue = 0;
    
    private int MaxArray(int indexStart, int[] array)
    {
        int max = array[indexStart];
        int maxValuesIndex = indexStart;

        indexStart += 1;
        indexStart = (indexMaxValue > indexStart) ? indexMaxValue : indexStart;
        
        for (int i = indexStart; i < array.Length; i++)
        {
            if (max < array[i])
            {
                maxValuesIndex = i;
                max = array[i];
            }
        }

        this.indexMaxValue = maxValuesIndex;
        return max;
    }
}