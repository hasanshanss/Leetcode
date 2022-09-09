using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection.Helpers
{
    internal static class DictionaryHelper
    {
        public static void MapCount<TKey>(this Dictionary<TKey, int> dictionary, TKey[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (dictionary.TryGetValue(array[i], out int count))
                {
                    dictionary[array[i]] = ++count;
                }
                else
                {
                    dictionary.Add(array[i], 1);
                }
            }
        }
    }
}
