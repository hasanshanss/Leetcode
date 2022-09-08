using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection.Helpers.Extensions
{
    public static class ArrayExtensions
    {
        public static void Swap<T>(this T[] source, long index1, long index2)
        {
            T temp = source[index1];
            source[index1] = source[index2];
            source[index2] = temp;
        }

        public static bool IsNullOrEmpty<T>(this T[] source)
        {
            return source == null || source.Length == 0;
        }
    }
}
