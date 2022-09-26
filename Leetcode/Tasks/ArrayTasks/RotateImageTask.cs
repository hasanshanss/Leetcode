using EasyCollection.Helpers;
using EasyCollection.Tasks.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection.Tasks.ArrayTasks
{
    internal class RotateImageTask : MultipleArrayBaseTask<int, int[]>
    {
        private readonly List<int[]> matrix;
        private readonly int n;
        public RotateImageTask(int[] image1, int[] image2) : base(new List<int[]> { image1, image2})
        {
            matrix = multipleArrayBaseTaskParams.Input;
            n = matrix.Count;
        }

        protected override int[] Solve()
        {
            Transpose();
            Reverse();
            return result;
        }


        public void Transpose()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int tmp = matrix[j][i];
                    matrix[j][i] = matrix[i][j];
                    matrix[i][j] = tmp;
                }
            }
        }

        public void Reverse()
        {
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    int tmp = matrix[i][j];
                    matrix[i][j] = matrix[i][n - j - 1];
                    matrix[i][n - j - 1] = tmp;
                }
            }
        }

        protected override void PrintResult()
        {
            Console.Write("\n\nResulted Array: ");
            PrintHelper<int>.PrintMatrix(matrix.ToArray());
        }
    }
}
