using System;
using System.Collections.Generic;
using SimpleNN.Core.Helpers;

namespace SimpleNN.Core.Models
{
    public class NeuralNetwork
    {
        public NeuralNetwork(double learningRate, params int[] nodeCounts)
        {
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
            LearningRate = learningRate;
        }

        private List<HiddenLayer> HiddenLayers { get; set; }

        private OutputLayer OutputLayer { get; set; }

        private Func<double, double> ActivationFunction = ActivationFunctions.Sigmoid;

        private Func<double, double> DerivativeFunction = ActivationFunctions.DerivativeSigmoid;

        private double LearningRate { get; set; }

        public double[] FeedForward(double[] input)
        {
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
                HiddenLayers[k].Activations = res;
                input = res;
            }

            OutputLayer.Result = res;
            //OutputLayer.Result.ShowArray();

            return res;
        }

        public void BackPropogateError(double[] expected)
        {
            for (int i = HiddenLayers.Count - 1; i >=0 ; i--)
            {
                double[] errors = new double[HiddenLayers[i].NodeCount];


                if (i != HiddenLayers.Count - 1)
                {
                    for (int j = 0; j < HiddenLayers[i].NodeCount; j++)
                    {
                        double error = 0.0;
                        for (int k = 0; k < HiddenLayers[i+1].NodeCount; k++)
                        {
                            error += HiddenLayers[i + 1].Weights[k, j] * HiddenLayers[i + 1].Delta[k];
                        }
                        errors[j] = error;
                    }
                }
                else
                {
                    for (int j = 0; j < OutputLayer.Result.Length; j++)
                    {
                        errors[j] = expected[j] - OutputLayer.Result[j];
                    }
                    
                }

                for (int j = 0; j < HiddenLayers[i].NodeCount; j++)
                {
                    errors[j] = errors[j] * DerivativeFunction.Invoke(HiddenLayers[i].Activations[j]);
                }
                HiddenLayers[i].Delta = errors;
            }
        }

        public void UpdateWeights(double[] input)
        {
            for (int i = 0; i < HiddenLayers.Count; i++)
            {
                if (i!=0) input = HiddenLayers[i - 1].Activations;

                for (int j = 0; j < HiddenLayers[i].NodeCount; j++)
                {
                    for (int k = 0; k < input.Length; k++)
                    {
                        HiddenLayers[i].Weights[j, k] += LearningRate * HiddenLayers[i].Delta[j] * input[k];
                    }
                    HiddenLayers[i].Bias[j] += LearningRate * HiddenLayers[i].Delta[j];
                }
            }
        }

        public void TrainNetwork(int epoch, TrainData[] trainData)
        {
            for (int i = 0; i < epoch; i++)
            {
                for (int j = 0; j < trainData.Length; j++)
                {
                    double sumError = 0.0;

                    var output = FeedForward(trainData[j].Data);
                    
                    var expected = new double[OutputLayer.Result.Length];
                    expected[trainData[j].Result] = 1;

                    for (int l = 0; l < expected.Length; l++)
                    {
                        sumError += Math.Pow(expected[l] - output[l], 2);
                    }

                    BackPropogateError(expected);
                    UpdateWeights(trainData[j].Data);

                    Console.WriteLine($">epoch={i}, trainDataIndex={j} error={sumError}");
                }
            }
        }
    }


}
