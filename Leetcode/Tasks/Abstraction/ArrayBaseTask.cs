using EasyCollection.Helpers.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection.Tasks.Abstraction
{
    internal abstract class ArrayBaseTask<INPUT_TYPE, RETURN_TYPE> : BaseTask<INPUT_TYPE, RETURN_TYPE>
    {
        protected ArrayBaseTaskParams<INPUT_TYPE> arrayBaseTaskParams;

        protected ArrayBaseTask()
        {
            arrayBaseTaskParams = new ArrayBaseTaskParams<INPUT_TYPE>();
        }

        protected ArrayBaseTask(INPUT_TYPE[] input) : this()
        {
            arrayBaseTaskParams.Input = input;
        }

        protected override void ThrowIfEmpty()
        {
            if (arrayBaseTaskParams.Input.IsNullOrEmpty())
                throw new ArgumentNullException(nameof(arrayBaseTaskParams.Input));
        }

        protected override void PrintInput()
        {
            Console.Write("Input: ");
            foreach (var item in arrayBaseTaskParams.Input)
            {
                Console.Write(item + ", ");
            }
        }

        protected override void PrintResult()
        {
            base.PrintResult();
        }
    }

    internal class ArrayBaseTaskParams<INPUT_TYPE> : BaseTaskParams<INPUT_TYPE>
    {
     
        public ArrayBaseTaskParams(INPUT_TYPE input) : base(input)
        {
        }

        public ArrayBaseTaskParams()
        {
            
        }

        public new INPUT_TYPE[] Input { get; set; }
    }
}

