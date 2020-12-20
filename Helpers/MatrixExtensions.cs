using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNN.Helpers
{
    public static class MatrixExtensions
    {
        public static void ShowMatrix(this int[,] arr)
        {
            int row = arr.GetLength(0);
            int column = arr.GetLength(1);

            Console.WriteLine("Matrix output:");
            for (int i = 0; i <= row - 1; i++)
            {
                for (int j = 0; j <= column - 1; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
