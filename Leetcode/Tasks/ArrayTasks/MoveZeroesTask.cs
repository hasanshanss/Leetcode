using EasyCollection.Helpers.Extensions;
using EasyCollection.Tasks.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection.Tasks.ArrayTasks
{
    internal class MoveZeroesTask : ArrayBaseTask<int, int[]>
    {
        private int lastNonZeroFoundAt;
        public MoveZeroesTask(int[] input) : base(input)
        {
            
        }

        protected override int[] Solve()
        {
            #region Alternative Solution
            //while (lastNonZeroFoundAt < arrayBaseTaskParams.Input.Length - 1)
            //{
            //    if (arrayBaseTaskParams.Input[current] == 0)
            //    {
            //        lastNonZeroFoundAt++;
            //        if (arrayBaseTaskParams.Input[lastNonZeroFoundAt] > 0)
            //        {
            //            arrayBaseTaskParams.Input.Swap(lastNonZeroFoundAt, current++);
            //        }
            //    }
            //    else
            //    {
            //        current++;
            //    }
            //}
            #endregion

            ReplaceNonZeroElements();
            FillRemainingZeroes();
            return arrayBaseTaskParams.Input;
        }

        private void FillRemainingZeroes()
        {
            for (int i = lastNonZeroFoundAt; i < arrayBaseTaskParams.Input.Length; i++)
            {
                arrayBaseTaskParams.Input[i] = 0;
            }
        }

        private void ReplaceNonZeroElements()
        {
            for (int i = 0; i < arrayBaseTaskParams.Input.Length; i++)
            {
                if (arrayBaseTaskParams.Input[i] != 0)
                {
                    arrayBaseTaskParams.Input[lastNonZeroFoundAt++] = arrayBaseTaskParams.Input[i];
                }
            }
        }
    }
}
