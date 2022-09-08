using EasyCollection.Helpers.Extensions;
using EasyCollection.Tasks.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection.Tasks.StringTasks
{
    internal class ReverseStringTask : StringBaseTask<char[]>
    {
        public ReverseStringTask(string input) : base(input)
        {
            
        }


        protected override char[] Solve()
        {
            char[] inputCharArray = baseTaskParams.Input.ToArray();
            int pointer1 = 0, pointer2 = inputCharArray.Length - 1;

            while (pointer1 <= pointer2)
            {
                inputCharArray.Swap(pointer1++, pointer2--);
            }

            result = inputCharArray;
            return result;
        }
    }
}
