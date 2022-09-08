using EasyCollection.Helpers;
using EasyCollection.Tasks.Abstraction;

namespace EasyCollection.Tasks.ArrayTasks
{
    internal class IntersectionTwoArraysTask : MultipleArrayBaseTask<int, int[]>
    {
        private readonly Dictionary<int, int> numberMap;
        private readonly List<int> resultList;
        private readonly int[] input1, input2;

        public IntersectionTwoArraysTask(List<int[]> inputArrayList) : base(inputArrayList)
        {
            input1 = inputArrayList[0];
            input2 = inputArrayList[1];
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
            for (int i = 0; i < input1.Length; i++)
            {
                if (numberMap.TryGetValue(input1[i], out int count))
                {
                    numberMap[input1[i]] = ++count;
                }
                else
                {
                    numberMap.Add(input1[i], 1);
                }
            }
        }

       
    }
}
