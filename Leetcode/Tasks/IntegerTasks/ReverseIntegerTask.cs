using EasyCollection.Tasks.Abstraction;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
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
                int mod = baseTaskParams.Input % 10;
                baseTaskParams.Input /= 10;

                if (CheckOverflow(mod)) return 0;

                result = result * 10 + mod;

            }

            return result;
        }

        private bool CheckMaxOverflow(int mod)
        {
            return (result > Int32.MaxValue / 10 || (result == Int32.MaxValue / 10 && mod > 7));
        }

        private bool CheckMinOverflow(int mod)
        {
            return (result < Int32.MinValue / 10 || (result == Int32.MinValue / 10 && mod < -8));
        }

        private bool CheckOverflow(int mod)
        {
            return CheckMinOverflow(mod) || CheckMaxOverflow(mod);
        }
    }
}
