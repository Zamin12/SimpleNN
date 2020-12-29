using System;
using System.Collections.Generic;
using SimpleNN.Helpers;

namespace SimpleNN.Models
{
    public class NeuralNetwork
    {
        public NeuralNetwork(Func<double, double> activationFunction, params int[] nodeCounts)
        {
            Input = new InputLayer();
            HiddenLayers = new List<HiddenLayer>();
            for (int i = 0; i <= nodeCounts.Length - 2; i++)
            {
                if (i != nodeCounts.Length - 2)
                {
                    var hiddenLayer = new HiddenLayer(nodeCounts[i], nodeCounts[i + 1]);
                    HiddenLayers.Add(hiddenLayer);
                }
                else
                {
                    var outputLayer = new OutputLayer(nodeCounts[i], nodeCounts[i + 1]);
                    OutputLayer = outputLayer;
                    HiddenLayers.Add(outputLayer);
                }
            }
            ActivationFunction = activationFunction;
        }

        public InputLayer Input { get; set; }

        public List<HiddenLayer> HiddenLayers { get; set; }

        public OutputLayer OutputLayer { get; set; }

        private Func<double, double> ActivationFunction;

        public void FeedForward(double[,] inputMatrix)
        {

            Input = new InputLayer(inputMatrix.GetLength(0), inputMatrix.GetLength(1), inputMatrix);
            var input = Input.InputNodes;

            double[] res = new double[0];
            for (int k = 0; k <= HiddenLayers.Count - 1; k++)
            {
                var weights = HiddenLayers[k].Weights;
                var bias = HiddenLayers[k].Bias;
                int row = weights.GetLength(0);
                int column = weights.GetLength(1);
                res = new double[row];

                for (int i = 0; i <= row - 1; i++)
                {
                    for (int j = 0; j <= column - 1; j++)
                    {
                        res[i] += weights[i, j] * input[j];
                    }
                    res[i] += bias[i];
                    res[i] = ActivationFunction.Invoke(res[i]);
                }
                input = res;
            }

            OutputLayer.Result = res;
            OutputLayer.ShowLayer();
        }
    }


}
