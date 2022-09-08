using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCollection.Tasks.Abstraction;

namespace EasyCollection.Tasks.ArrayTasks
{
    internal class ContainsDuplicateTask : ArrayBaseTask<int, bool>
    {

        public ContainsDuplicateTask(int[] input) : base(input)
        {
            
        }
        protected override bool Solve()
        {
            HashSet<int> duplicates = new HashSet<int>();
            for (int i = 0; i < arrayBaseTaskParams.Input.Length; i++)
            {
                if (duplicates.Contains(arrayBaseTaskParams.Input[i]))
                {
                    return true;
                }
                duplicates.Add(arrayBaseTaskParams.Input[i]);
            }

            return false;
        }
    }
}
