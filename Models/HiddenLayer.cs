using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNN.Models
{
    public class HiddenLayer
    {
        public int NodeCount { get; set; }
        public int InputCount { get; set; }
        public double[,] Weights { get; 
            set; }
        public double[] Bias { get; set; }

        public HiddenLayer(int nodeCount, int inputCount, double[,] weights, double[] bias) : this(nodeCount, inputCount)
        {
            this.NodeCount = nodeCount;
            this.InputCount = inputCount;

            Weights = weights;
            Bias = bias;
        }

        public HiddenLayer(int nodeCount, int inputCount)
        {
            this.NodeCount = nodeCount;
            this.InputCount = inputCount;

            Weights = new double[nodeCount, inputCount];
            Bias = new double[nodeCount];
        }

    }
}
