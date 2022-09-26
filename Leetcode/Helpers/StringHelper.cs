using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection.Helpers
{
    internal static class StringHelper
    {
        public static string StringBuilderChars(IEnumerable<char> charSequence)
        {
            var sb = new StringBuilder();
            foreach (var c in charSequence)
            {
                sb.Append(c);
            }
            return sb.ToString();
        }

    }
}
