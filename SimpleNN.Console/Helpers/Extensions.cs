using System;
namespace SimpleNN.Console.Helpers
{
    public static class Extensions
    {
        //public static void ShowLayer(this HiddenLayer hiddenLayer)
        //{
        //    bool isOutputLayer = hiddenLayer is OutputLayer;
        //    int row = hiddenLayer.Weights.GetLength(0);
        //    int column = hiddenLayer.Weights.GetLength(1);

        //    Console.WriteLine(!isOutputLayer ? "Hidden layer:" : "Output Layer");

        //    if (isOutputLayer)
        //    {
        //        var outputLayer = hiddenLayer as OutputLayer;
        //        for (int i = 0; i <= outputLayer.Result.Length - 1; i++)
        //        {
        //            Console.Write(outputLayer.Result[i] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //    else
        //    {
        //        for (int i = 0; i <= row - 1; i++)
        //        {
        //            for (int j = 0; j <= column - 1; j++)
        //            {
        //                Console.Write(hiddenLayer.Weights[i, j] + " ");
        //            }
        //            Console.WriteLine();
        //        }
        //    }
        //}

        //public static void ShowArray(this double[] arr)
        //{
        //    Console.WriteLine("Result:");
        //    for (int i = 0; i <= arr.Length - 1; i++)
        //    {
        //        Console.Write(Math.Round(arr[i], 4) + " ");
        //    }
        //    Console.WriteLine();
        //}
    }
}
