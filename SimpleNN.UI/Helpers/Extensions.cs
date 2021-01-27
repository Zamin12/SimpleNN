using System;

namespace SimpleNN.UI.Helpers
{
    public static class Extensions
    {
        public static void ShowMatrixArray(this double[,] arr)
        {
            int row = arr.GetLength(0);
            int column = arr.GetLength(1);

            for (int i = 0; i <= row - 1; i++)
            {
                for (int j = 0; j <= column - 1; j++)
                {
                    Console.Write(Math.Round(arr[i, j],2).ToString().PadLeft(4) + " ");
                }
                Console.WriteLine();
            }
        }

        public static void ShowArray(this double[] arr)
        {
            Console.WriteLine("Result:");
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.Write(Math.Round(arr[i], 4) + " ");
            }
            Console.WriteLine();
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
