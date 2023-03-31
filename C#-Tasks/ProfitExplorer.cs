using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Tasks
{
    internal class ProfitExplorer
    {
        public static int FindMaximumProfit(int[] prices,int index)
        {
            int maxProfit = 0;
            int minPrice = int.MaxValue;

            for (int i = 0; i < index; i++)
            {
                if (prices[i] < minPrice)
                {
                    // Update the minimum price seen so far
                    minPrice = prices[i];
                }
                else if (prices[i] - minPrice > maxProfit)
                {
                    // Update the maximum profit if we can make more by selling on this day
                    maxProfit = prices[i] - minPrice;
                }
            }
            return maxProfit;
        }
        static void ss(string[] args)
        {

            
           // int[] arr = { 7, 1, 5, 3, 6, 4 }
            Console.Write("Enter index : ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Array : ");
            int[] arr = new int[index];
            for(int i=0 ; i < index; i++)
            {
                 arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Maximum Profit can be Achieved by : "+FindMaximumProfit(arr,index));
        }
    }
}
