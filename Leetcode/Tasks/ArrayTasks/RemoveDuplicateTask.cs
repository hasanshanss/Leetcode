using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCollection.Tasks.Abstraction;

namespace EasyCollection.Tasks.ArrayTasks
{
    internal class RemoveDuplicateTask : ArrayBaseTask<int, int>
    {
        private int pointer1, pointer2 = 1, uniqueNums;
        
        public RemoveDuplicateTask(int[] input) : base(input)
        {
            
        }
        protected override int Solve()
        {
            while (pointer2 < arrayBaseTaskParams.Input.Length)
            {
                if (arrayBaseTaskParams.Input[pointer1] != arrayBaseTaskParams.Input[pointer2])
                {
                    arrayBaseTaskParams.Input[++pointer1] = arrayBaseTaskParams.Input[pointer2];
                }
                pointer2++;
            }

            uniqueNums = ++pointer1;
            for (; pointer1 < arrayBaseTaskParams.Input.Length; pointer1++)
            {
                arrayBaseTaskParams.Input[pointer1] = 0;
            }

            return uniqueNums;
        }
    }
}
