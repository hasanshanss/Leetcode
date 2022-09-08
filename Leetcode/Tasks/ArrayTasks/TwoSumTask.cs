using EasyCollection.Tasks.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection.Tasks.ArrayTasks
{
    internal class TwoSumTask : ArrayBaseTask<int, int[]>
    {
        private TwoSumTaskParams<int> taskParams;

        public TwoSumTask(int[] input, int target) : base(input)
        {
            taskParams = new TwoSumTaskParams<int>(target);
        }

        protected override int[] Solve()
        {
            Dictionary<int, int> numbersMap = new Dictionary<int, int>();
            for(int i = 0; i < arrayBaseTaskParams.Input.Length; i++)
            {
                if (numbersMap.TryGetValue(arrayBaseTaskParams.Input[i], out int differenceIndex))
                {
                   return new int[] { i , differenceIndex };
                }
                else
                {
                    numbersMap.TryAdd(taskParams.Target - arrayBaseTaskParams.Input[i], i);
                }
            }
            return new int[] { };
        }
    }

    internal class TwoSumTaskParams<INPUT_TYPE> : ArrayBaseTaskParams<INPUT_TYPE>
    {
        public TwoSumTaskParams(int target)
        {
            Target = target;
        }

        public int Target { get; set; }
    }
}
