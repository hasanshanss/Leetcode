using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCollection.Tasks.Abstraction;

namespace EasyCollection.Tasks.ArrayTasks
{
    internal class SingleNumberTask : ArrayBaseTask<int, int>
    {
        
        public SingleNumberTask(int[] input) : base(input)
        {
            
        }
        protected override int Solve()
        {
            HashSet<int> repeats = new HashSet<int>();

            foreach (var item in arrayBaseTaskParams.Input)
            {
                if (repeats.Contains(item))
                {
                    repeats.Remove(item);
                }
                else
                {
                    repeats.Add(item);
                }
            }

            return repeats.Single();
        }
    }
}
