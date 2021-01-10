using System;
using System.Collections.Generic;
using System.Text;
using SimpleNN.Core.Helpers;

namespace SimpleNN.Core.Models
{
    public class HiddenLayer
    {
        public int NodeCount { get; set; }

        public int InputCount { get; set; }

        public double[,] Weights { get; set; }

        public double[] Bias { get; set; }

        public double[] Activations { get; set; }

        public double[] Delta { get; set; }

        public HiddenLayer(int inputCount, int nodeCount, double[,] weights, double[] bias) : this(nodeCount, inputCount)
        {
            this.NodeCount = nodeCount;
            this.InputCount = inputCount;

            Weights = weights;
            Bias = bias;
        }

        public HiddenLayer(int inputCount, int nodeCount)
        {
            this.NodeCount = nodeCount;
            this.InputCount = inputCount;

            Weights = new double[nodeCount, inputCount];
            Bias = new double[nodeCount];
            Weights.InitWeights();
            Bias.InitBias();
        }
    }
}
