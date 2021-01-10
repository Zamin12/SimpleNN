﻿using System;
using SimpleNN.Core.Models;

namespace SimpleNN.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            NeuralNetwork nn = new NeuralNetwork(0.1, 15, 20, 10);

            var input0 = new double[5, 3] {
                { 1.0, 1.0, 1.0 },
                { 1.0, 0.0, 1.0 },
                { 1.0, 0.0, 1.0 },
                { 1.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 }
            };

            var input1 = new double[5, 3] {
                { 0.0, 0.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 0.0, 0.0, 1.0 }
            };

            var input2 = new double[5, 3] {
                { 1.0, 1.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 },
                { 1.0, 0.0, 0.0 },
                { 1.0, 1.0, 1.0 }
            };

            var input3 = new double[5, 3] {
                { 1.0, 1.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 }
            };

            var input4 = new double[5, 3] {
                { 1.0, 0.0, 1.0 },
                { 1.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 0.0, 0.0, 1.0 }
            };

            var input5 = new double[5, 3] {
                { 1.0, 1.0, 1.0 },
                { 1.0, 0.0, 0.0 },
                { 1.0, 1.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 }
            };

            var input6 = new double[5, 3] {
                { 1.0, 1.0, 1.0 },
                { 1.0, 0.0, 0.0 },
                { 1.0, 1.0, 1.0 },
                { 1.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 }
            };

            var input7 = new double[5, 3] {
                { 1.0, 1.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 0.0, 0.0, 1.0 }
            };

            var input8 = new double[5, 3] {
                { 1.0, 1.0, 1.0 },
                { 1.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 },
                { 1.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 }
            };

            var input9 = new double[5, 3] {
                { 1.0, 1.0, 1.0 },
                { 1.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 }
            };

            nn.TrainNetwork(10000, new double[10][,] { input0, input1, input2, input3, input4, input5, input6, input7, input8, input9 }, new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            
            //NeuralNetwork nn = new NeuralNetwork(ActivationFunctions.Sigmoid, 2, 1, 2);

            //nn.FeedForward(new double[2, 1] {
            //    { 0.0 },
            //    { 1.0 }
            //});

            //nn.BackPropogation(new double[2] { 0.0, 1.0 });
        }

    }
}
