using EasyCollection.Helpers;
using EasyCollection.Tasks.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection.Tasks.StringTasks
{
    internal class FirstUniqueCharTask : StringBaseTask<int>
    {
        private Dictionary<char, int> charMap;
        private char[] charArray; 
        public FirstUniqueCharTask(string input) : base(input)
        {
            charArray = baseTaskParams.Input.ToCharArray();
            charMap = new Dictionary<char, int>();
        }

        protected override int Solve()
        {
            charMap.MapCount(charArray);
            
            for(int i = 0; i < charArray.Length; i++)
            {
                if (charMap.GetValueOrDefault(charArray[i]) == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
