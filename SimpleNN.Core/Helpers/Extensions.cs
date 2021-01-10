using System;


namespace SimpleNN.Core.Helpers
{
    public static class Extensions
    {
        public static void InitWeights(this double[,] arr)
        {
            Random random = new Random();

            int row = arr.GetLength(0);
            int column = arr.GetLength(1);

            for (int i = 0; i <= row - 1; i++)
            {
                for (int j = 0; j <= column - 1; j++)
                {
                    arr[i, j] = (double)random.Next(101) / 100.0;
                }
            }
        }

        public static void InitBias(this double[] arr)
        {
            Random random = new Random();

            int length = arr.Length;

            for (int i = 0; i <= length - 1; i++)
            {
                arr[i] = (double)random.Next(101) / 100.0;
            }
        }

        public static double[] MatrixToArray(this double[,] matrix)
        {
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);
            double[] res = new double[row * column]; 
            int z = 0;
            for (int i = 0; i <= row - 1; i++)
            {
                for (int j = 0; j <= column - 1; j++)
                {
                    res[z++] = matrix[i, j];
                }
            }
            return res;
        }
    }
}
