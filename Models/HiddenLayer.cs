using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNN.Models
{
    public class HiddenLayer
    {
        public int NodeCount { get; set; }
        public int InputCount { get; set; }
        public int[,] Weights { get; 
            set; }
        public int[] Bias { get; set; }

        public HiddenLayer(int nodeCount, int inputCount, int[,] weights) : this(nodeCount, inputCount)
        {
            this.NodeCount = nodeCount;
            this.InputCount = inputCount;

            Weights = weights;
        }

        public HiddenLayer(int nodeCount, int inputCount)
        {
            this.NodeCount = nodeCount;
            this.InputCount = inputCount;

            Weights = new int[nodeCount, inputCount];
            Bias = new int[nodeCount];
        }

    }
}
