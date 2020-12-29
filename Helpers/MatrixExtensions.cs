using System;
using System.Collections.Generic;
using System.Text;
using SimpleNN.Models;

namespace SimpleNN.Helpers
{
    public static class MatrixExtensions
    {
        public static void ShowLayer(this HiddenLayer hiddenLayer)
        {
            bool isOutputLayer = hiddenLayer is OutputLayer;
            int row = hiddenLayer.Weights.GetLength(0);
            int column = hiddenLayer.Weights.GetLength(1);

            Console.WriteLine(!isOutputLayer?"Hidden layer:": "Output Layer");

            if (isOutputLayer)
            {
                var outputLayer = hiddenLayer as OutputLayer;
                for (int i = 0; i <= outputLayer.Result.Length - 1; i++)
                {
                    Console.Write(outputLayer.Result[i] + " ");
                }
            }
            else
            {
                for (int i = 0; i <= row - 1; i++)
                {
                    for (int j = 0; j <= column - 1; j++)
                    {
                        Console.Write(hiddenLayer.Weights[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

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
    }
}
