using EasyCollection.Tasks.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection.Tasks.StringTasks
{
    internal class ValidPalindromeTask : StringBaseTask<bool>
    {
        private int pointer1, pointer2;
        private char[] chars;
        public ValidPalindromeTask(string input) : base(input)
        {
             pointer2 = baseTaskParams.Input.Length - 1;
             chars = baseTaskParams.Input.ToLower().ToCharArray();
        }

        protected override bool Solve()
        {
            while (pointer1 < pointer2)
            {
                IterateTillAlphaNumeric(ref pointer1, IterateForward);
                IterateTillAlphaNumeric(ref pointer2, IterateReverse);

                if (chars[pointer1] != chars[pointer2])
                {
                    return false;
                }

                IterateForward();
                IterateReverse();
            }

            return true;
        }

        private void IterateTillAlphaNumeric(ref int startIndex, Action iteration)
        {
            while (pointer1 < pointer2 && !IsAlphaNumeric(startIndex))
            {
                iteration();
            }
        }

        private void IterateReverse()
        {
            pointer2--;
        }

        private void IterateForward()
        {
            pointer1++;
        }

        private bool IsAlphaNumeric(int index) =>((chars[index] >= 'a' && chars[index] <= 'z') || (chars[index] >= '0' && chars[index] <= '9'));
    }
}
