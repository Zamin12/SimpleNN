using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNN.Models
{
    public class OutputLayer : HiddenLayer
    {
        public OutputLayer(int nodeCount, int inputCount, int[,] weights) : base(nodeCount, inputCount, weights)
        {
            Result = new int[nodeCount];
        }

        public int[] Result { get; set; }
    }
}
