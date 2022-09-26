using EasyCollection.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection.Tasks.Abstraction
{
    internal abstract class BaseTask<INPUT_TYPE, RETURN_TYPE> : ITask<RETURN_TYPE>
    {
        protected BaseTaskParams<INPUT_TYPE> baseTaskParams;

        protected RETURN_TYPE result;
        protected abstract RETURN_TYPE Solve();

        public BaseTask()
        {
            baseTaskParams = new BaseTaskParams<INPUT_TYPE>();
        }

        public BaseTask(INPUT_TYPE input) : this()
        {
            baseTaskParams.Input = input;
        }

        public RETURN_TYPE Do()
        {
            ThrowIfEmpty();

            PrintInput();
            result = Solve();
            PrintResult();

            return result;
        }

        protected virtual void PrintInput()
        {
            Console.Write("Input: ");
            PrintHelper<INPUT_TYPE>.Print(baseTaskParams.Input);
        }

        protected virtual void ThrowIfEmpty()
        {
            if (baseTaskParams.Input == null)
                throw new ArgumentNullException(nameof(baseTaskParams.Input));
        }

        protected virtual void PrintResult()
        {
            Console.Write("\n\nResult: ");
            PrintHelper<RETURN_TYPE>.Print(result);

        }

    }
    internal class BaseTaskParams<T>
    {
        public BaseTaskParams()
        {
        }

        public BaseTaskParams(T input)
        {
            Input = input;
        }

        public T Input { get; set; }
    }
}
