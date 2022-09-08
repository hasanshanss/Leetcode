using EasyCollection.Helpers.Extensions;
using EasyCollection.Tasks.Abstraction;

namespace EasyCollection.Tasks.ArrayTasks
{
    internal class RotateArrayTask : ArrayBaseTask<int, byte>
    {
        RotateArrayTaskParams<int> rotateArrayTaskParams;

        public RotateArrayTask(int[] input, int separateLevel) : base(input)
        {
            rotateArrayTaskParams = new RotateArrayTaskParams<int>(separateLevel);
        }
        private void ReversePartialArray(int pointer1, int pointer2)
        {
            while (pointer1 <= pointer2)
            {
                arrayBaseTaskParams.Input.Swap(pointer1++, pointer2--);
            }
        }

        protected override byte Solve()
        {
            Array.Reverse(arrayBaseTaskParams.Input);
            ReversePartialArray(0, rotateArrayTaskParams.SeparateLevel - 1);
            ReversePartialArray(rotateArrayTaskParams.SeparateLevel, arrayBaseTaskParams.Input.Length - 1);
            return 1;
        }
    }

    internal class RotateArrayTaskParams<INPUT_TYPE> : ArrayBaseTaskParams<INPUT_TYPE>
    {
        public RotateArrayTaskParams(int separateLevel)
        {
            SeparateLevel = separateLevel;
        }

        public int SeparateLevel { get; set; }
    }

}
