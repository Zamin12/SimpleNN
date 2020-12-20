using System;
using System.Collections.Generic;

namespace SimpleNN.Models
{
    public class NeuralNetwork
    {
        public NeuralNetwork() 
        {
        
        }

        public InputLayer Input { get; set; }

        public List<HiddenLayer> HiddenLayer1 { get; set; }

        public OutputLayer OutputLayer { get; set; }

        public int[] FeedForward(int[] input, int[,] weights, int[] bias, Func<int, int> activation)
        {
            int row = weights.GetLength(0);
            int column = weights.GetLength(1);
            int[] res = new int[row];

            for (int i = 0; i <= row - 1; i++)
            {
                for (int j = 0; j <= column - 1; j++)
                {
                    res[i] += weights[i, j] * input[j];
                }
                res[i] += bias[i];
                res[i] = activation.Invoke(res[i]);
            }

            return res;
        }
    }


}
