﻿using System.Drawing;
using SimpleNN.Core.Models;
using SimpleNN.UI.Helpers;
using System.IO;
using System;

namespace SimpleNN.UI
{
    public class HandWritings
    {
        public HandWritings()
        {
            NeuralNetwork nn = new NeuralNetwork(0.01, 784, 16, 10);

            var traindata = ReadTrainData();

            do
            {
                Console.Write("Actions: 1.Train 2.Test ");
                string l = Console.ReadLine();
                switch (int.Parse(l))
                {
                    case 1:
                        Console.Write("Train size: ");
                        var trainSize = Console.ReadLine();
                        nn.TrainNetwork(int.Parse(trainSize), traindata);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Test size: ");
                        var testSize = Console.ReadLine();

                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (true);


            nn.FeedForward(traindata[5].Data).ShowArray();
            Console.Write(traindata[5].Result);

            nn.FeedForward(traindata[100].Data).ShowArray();
            Console.Write(traindata[5].Result);


        }

        public TrainData[] ReadTrainData()
        {
            var files = Directory.GetFiles(app.Default.trainUrl);
            var result = new TrainData[100];

            for (int i = 0; i < 100; i++)
            {
                result[i] = new TrainData(28, 28);

                result[i].Result = int.Parse( files[i].Substring(files[i].Length - 5, 1));
                Bitmap image = new Bitmap(files[i]);

                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        result[i].Data[y * 28 + x] = image.GetPixel(x, y).GetBrightness();
                    }
                }

            }
            return result;
        }
    }
}
