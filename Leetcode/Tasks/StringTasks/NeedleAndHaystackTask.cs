using EasyCollection.Tasks.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection.Tasks.StringTasks
{
    internal class NeedleAndHaystackTask : ArrayBaseTask<string, int>
    {
        public NeedleAndHaystackTask(string haystack, string needle) : base(new string[] { haystack, needle }) 
        {
            
        }

        protected override int Solve()
        {
            string haystack = arrayBaseTaskParams.Input[0];
            string needle = arrayBaseTaskParams.Input[1];

            if (haystack.Length < needle.Length)
                return -1;

                for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
