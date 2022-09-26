using EasyCollection.Helpers;
using EasyCollection.Tasks.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection.Tasks.StringTasks
{
    internal class LongestCommonPrefixTask : MultipleArrayBaseTask<char, string>
    {
        public LongestCommonPrefixTask(string[] input) : base()
        {
            foreach (var s in input)
            {
                multipleArrayBaseTaskParams.Input.Add(s.ToCharArray());
            }
        }

        protected override string Solve()
        {
            var words = multipleArrayBaseTaskParams.Input;

            for (int i = 0; i < words[0].Length; i++)
            {
                char prefix = words[0][i];
                for(int j = 1; j < words.Count; j++)
                {
                    if (i == words[j].Length || words[j][i] != prefix)
                    {
                        return StringHelper.StringBuilderChars(words[0].Take(i));
                    }
                }
                
            }

            return StringHelper.StringBuilderChars(words[0]);
        }
    }
}
