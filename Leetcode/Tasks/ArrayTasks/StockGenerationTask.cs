using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCollection.Tasks.Abstraction;

namespace EasyCollection.Tasks.ArrayTasks
{
    internal class StockGenerationTask : ArrayBaseTask<int, int>
    {
        
        public StockGenerationTask(int[] input) : base(input)
        {
            
        }
        protected override int Solve()
        {
            int maxProfit = 0;

            for (int i = 1; i < arrayBaseTaskParams.Input.Length; i++)
            {
                int tomorrowPrice = arrayBaseTaskParams.Input[i],
                    todayPrice = arrayBaseTaskParams.Input[i - 1];

                if (tomorrowPrice > todayPrice)
                {
                    maxProfit += tomorrowPrice - todayPrice;
                }
            }

            return maxProfit;
        }
    }
}
