using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCollection.Tasks.Abstraction;

namespace EasyCollection.Tasks.ArrayTasks
{
    internal class PlusOneTask : ArrayBaseTask<int, int[]>
    {
        
        public PlusOneTask(int[] input) : base(input)
        {
            
        }
        protected override int[] Solve()
        {
            CheckForUpdateArray(arrayBaseTaskParams.Input.Length - 1);
            CheckForNewArray();

            return arrayBaseTaskParams.Input;
        }

        public void CheckForNewArray()
        {
            if (arrayBaseTaskParams.Input[0] == 0)
            {
                arrayBaseTaskParams.Input = new int[arrayBaseTaskParams.Input.Length + 1];
                arrayBaseTaskParams.Input[0] = 1;
            }
        }

        public void CheckForUpdateArray(int index)
        {
            if (index < 0)
                return;

            ref int currentNum = ref arrayBaseTaskParams.Input[index];
            bool isNine = currentNum == 9;

            currentNum = isNine ? 0 : currentNum + 1;

            if (isNine)
                CheckForUpdateArray(index - 1);
        }

    }
}
