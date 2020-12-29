using System;
using SimpleNN.Helpers;
using SimpleNN.Models;

namespace SimpleNN
{
    class Program
    {
        static void Main(string[] args)
        {

            //NeuralNetwork nn = new NeuralNetwork(ActivationFunctions.Sigmoid, 15, 7, 10);

            //nn.FeedForward(new double[5,3] {
            //    { 0.0, 0.0, 1.0 },
            //    { 0.0, 0.0, 1.0 },
            //    { 0.0, 0.0, 1.0 },
            //    { 0.0, 0.0, 1.0 },
            //    { 0.0, 0.0, 1.0 }
            //});

            NeuralNetwork nn = new NeuralNetwork(ActivationFunctions.Sigmoid, 2, 1, 2);

            nn.FeedForward(new double[2, 1] {
                { 0.0 },
                { 1.0 }
            });

            Console.ReadLine();
        }

    }
}
