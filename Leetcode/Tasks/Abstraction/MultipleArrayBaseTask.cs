using EasyCollection.Helpers;
using EasyCollection.Helpers.Extensions;

namespace EasyCollection.Tasks.Abstraction
{
    internal abstract class MultipleArrayBaseTask<INPUT_TYPE, RETURN_TYPE>
        : BaseTask<INPUT_TYPE, RETURN_TYPE>
    {
        protected MultipleArrayBaseTaskParams<INPUT_TYPE> multipleArrayBaseTaskParams;
        protected MultipleArrayBaseTask(MultipleArrayBaseTaskParams<INPUT_TYPE> multipleArrayBaseTaskParams) : base(multipleArrayBaseTaskParams)
        {
            this.multipleArrayBaseTaskParams = multipleArrayBaseTaskParams;
        }

        protected MultipleArrayBaseTask()
        {
            this.multipleArrayBaseTaskParams = new MultipleArrayBaseTaskParams<INPUT_TYPE>();
        }

        protected MultipleArrayBaseTask(List<INPUT_TYPE[]> inputArrayList) : this()
        {
            this.multipleArrayBaseTaskParams.Input = inputArrayList;
        }


        protected override void ThrowIfEmpty()
        {
            foreach (var inputArray in multipleArrayBaseTaskParams.Input)
            {
                if (inputArray.IsNullOrEmpty())
                    throw new ArgumentNullException(nameof(inputArray));
            }
        }

        protected override void PrintInput()
        {
            for (int i = 0; i < multipleArrayBaseTaskParams.Input.Count; i++)
            {
                Console.Write($"\nInput Array No {i}: ");
                PrintHelper<INPUT_TYPE>.PrintArray(multipleArrayBaseTaskParams.Input[i]);
            }
        }

        protected override void PrintResult()
        {
            base.PrintResult();
        }
    }

    internal class MultipleArrayBaseTaskParams<INPUT_TYPE> : ArrayBaseTaskParams<INPUT_TYPE>
    {
        public MultipleArrayBaseTaskParams()
        {
            Input = new List<INPUT_TYPE[]>();
        }

        public MultipleArrayBaseTaskParams(List<INPUT_TYPE[]> input)
        {
            Input = input;
        }

        public new List<INPUT_TYPE[]> Input { get; set; }
    }
}
