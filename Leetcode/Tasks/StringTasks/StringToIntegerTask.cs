using EasyCollection.Tasks.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection.Tasks.StringTasks
{
    internal class StringToIntegerTask : StringBaseTask<int>
    {
        private int indexOfChar = 0, sign = 1;
        private readonly char[] chars;
        public StringToIntegerTask(string input) : base(input)
        {
            chars = baseTaskParams.Input.Trim().ToCharArray();
        }

        protected override int Solve()
        {
            DefineSign();

            while (indexOfChar < chars.Length)
            {
                char currentChar = chars[indexOfChar++];

                if (!CheckForNum(currentChar))
                    break;

                int num = MapCharToInt(currentChar);

                if (CheckForIntOverflow(currentChar))
                {
                    return sign < 0 ? int.MinValue : int.MaxValue;
                }

                result = result == 0 ? num : result * 10 + num;
            }

            return result * sign;
        }

        private void DefineSign()
        {
            if (CheckForSign(chars[indexOfChar]))
            {
                sign = CheckForNegativeSign(chars[indexOfChar++]) ? 1 : -1;
            }
        }

        private bool CheckForIntOverflow(char c) => result > int.MaxValue / 10 || (result == int.MaxValue / 10 && c - '0' > 7);
        private bool CheckForNum(char c) => (c >= '0' && c <= '9') || CheckForSign(c);
        private bool CheckForNegativeSign(char c) => c == '-';
        private bool CheckForPositiveSign(char c) => c == '+';
        private bool CheckForSign(char c) => CheckForPositiveSign(c) || CheckForNegativeSign(c);
        private int MapCharToInt(char c) => c - '0';


    }
}
