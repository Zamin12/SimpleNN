using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNN.Core.Models
{
    public class OutputLayer : HiddenLayer
    {
        public OutputLayer(int nodeCount, int inputCount, double[,] weights, double[] bias) : base(nodeCount, inputCount, weights, bias)
        {
            Result = new double[nodeCount];
        }

        public OutputLayer(int nodeCount, int inputCount) : base(nodeCount, inputCount)
        {
            Result = new double[nodeCount];
        }

        public double[] Result { get; set; }
    }
}
