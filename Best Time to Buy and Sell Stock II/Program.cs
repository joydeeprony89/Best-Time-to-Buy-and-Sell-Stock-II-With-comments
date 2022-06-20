using System;

namespace Best_Time_to_Buy_and_Sell_Stock_II
{
  class Program
  {
    static void Main(string[] args)
    {
      var prices = new int[] { 0, 8, 10, 0, 14 };
      Solution s = new Solution();
      var answer = s.MaxProfit(prices);
      Console.WriteLine(answer);
    }
  }

  public class Solution
  {
    public int MaxProfit(int[] prices)
    {
      // here we are allowed to do as many no of transactions
      int max = 0;
      for (int i = 1; i < prices.Length; i++)
      {
        if (prices[i] > prices[i - 1])
        {
          max += prices[i] - prices[i - 1];
        }
      }

      return max;
    }
  }
}
