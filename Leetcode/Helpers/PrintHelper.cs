using EasyCollection.Tasks.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection.Helpers
{
    internal static class PrintHelper<T>
    {
        public static bool PrintIfArray(T input)
        {
            var inputArray = input as System.Collections.IEnumerable;
            bool isArray = inputArray != null;

            if (isArray)
            {
                PrintArray(inputArray);
            }
            return isArray;
        }

        public static void Print(T input)
        {
            if (!PrintIfArray(input))
            {
                Console.Write(input);
            }
        }

        public static void PrintArray(System.Collections.IEnumerable inputArray)
        {
            foreach (var item in inputArray)
            {
                Console.Write(item + ", ");
            }
        }

        public static void PrintMatrix(System.Collections.IEnumerable[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write($"\nArray No {i}: ");
                PrintHelper<int>.PrintArray(inputArray[i]);
            }
        }
    }
}
