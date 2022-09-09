using EasyCollection.Helpers;
using EasyCollection.Tasks.Abstraction;

namespace EasyCollection.Tasks.ArrayTasks
{
    internal class IntersectionTwoArraysTask : MultipleArrayBaseTask<int, int[]>
    {
        private readonly Dictionary<int, int> numberMap;
        private readonly List<int> resultList;

        public IntersectionTwoArraysTask(List<int[]> inputArrayList) : base(inputArrayList)
        {
            numberMap = new Dictionary<int, int>();
            resultList = new List<int>();
        }

        protected override int[] Solve()
        {
            FillNumberMap();
            CheckForMatches();
            return resultList.ToArray();
        }

        private void CheckForMatches()
        {
            var input2 = multipleArrayBaseTaskParams.Input[1];

            for (int i = 0; i < input2.Length; i++)
            {
                if (numberMap.TryGetValue(input2[i], out int count) && count > 0)
                {
                    resultList.Add(input2[i]);
                    numberMap[input2[i]] = --count;
                }
            }
        }

        private void FillNumberMap()
        {
            numberMap.MapCount(multipleArrayBaseTaskParams.Input[0]);
        }

       
    }
}
