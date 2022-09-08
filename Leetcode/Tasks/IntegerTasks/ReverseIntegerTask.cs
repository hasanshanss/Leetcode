using EasyCollection.Tasks.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection.Tasks.IntegerTasks
{
    internal class ReverseIntegerTask : BaseTask<int, int>
    {
        public ReverseIntegerTask(int input) : base(input)
        {
            
        }

        protected override int Solve()
        {
            while (baseTaskParams.Input != 0)
            {
                result = result * 10 + baseTaskParams.Input % 10;
                baseTaskParams.Input /= 10;
            }

            return result;
        }
    }
}
