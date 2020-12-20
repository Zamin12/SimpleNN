﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNN.Models
{
    public class OutputLayer : HiddenLayer
    {
        public OutputLayer(int nodeCount, int inputCount, double[,] weights, double[] bias) : base(nodeCount, inputCount, weights, bias)
        {
            Result = new double[nodeCount];
        }

        public double[] Result { get; set; }
    }
}
