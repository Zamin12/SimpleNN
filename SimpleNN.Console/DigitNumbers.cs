using SimpleNN.UI.Helpers;
using SimpleNN.Core.Models;

namespace SimpleNN.UI
{
    public class DigitNumbers
    {
        public DigitNumbers()
        {
            NeuralNetwork nn = new NeuralNetwork(0.1, 15, 20, 10);

            TrainData trainData0 = new TrainData(5, 3)
            {
                Data = new double[5, 3] {
                { 1.0, 1.0, 1.0 },
                { 1.0, 0.0, 1.0 },
                { 1.0, 0.0, 1.0 },
                { 1.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 }
            }.MatrixToArray()
            ,
                Result = 0
            };

            TrainData trainData1 = new TrainData(5, 3)
            {
                Data = new double[5, 3] {
                { 0.0, 0.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 0.0, 0.0, 1.0 }
                        }.MatrixToArray()
            ,
                Result = 1
            };

            TrainData trainData2 = new TrainData(5, 3)
            {
                Data = new double[5, 3] {
                { 1.0, 1.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 },
                { 1.0, 0.0, 0.0 },
                { 1.0, 1.0, 1.0 }
                        }.MatrixToArray()
            ,
                Result = 2
            };

            TrainData trainData3 = new TrainData(5, 3)
            {
                Data = new double[5, 3] {
                { 1.0, 1.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 }
            }.MatrixToArray()
            ,
                Result = 3
            };

            TrainData trainData4 = new TrainData(5, 3)
            {
                Data = new double[5, 3] {
                { 1.0, 0.0, 1.0 },
                { 1.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 0.0, 0.0, 1.0 }
                        }.MatrixToArray()
            ,
                Result = 4
            };

            TrainData trainData5 = new TrainData(5, 3)
            {
                Data = new double[5, 3] {
                { 1.0, 1.0, 1.0 },
                { 1.0, 0.0, 0.0 },
                { 1.0, 1.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 }
                      }.MatrixToArray()
            ,
                Result = 5
            };

            TrainData trainData6 = new TrainData(5, 3)
            {
                Data = new double[5, 3] {
                { 1.0, 1.0, 1.0 },
                { 1.0, 0.0, 0.0 },
                { 1.0, 1.0, 1.0 },
                { 1.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 }
                       }.MatrixToArray()
            ,
                Result = 6
            };

            TrainData trainData7 = new TrainData(5, 3)
            {
                Data = new double[5, 3] {
                { 1.0, 1.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 0.0, 0.0, 1.0 }
                        }.MatrixToArray()
            ,
                Result = 7
            };

            TrainData trainData8 = new TrainData(5, 3)
            {
                Data = new double[5, 3] {
                { 1.0, 1.0, 1.0 },
                { 1.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 },
                { 1.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 }
                        }.MatrixToArray()
            ,
                Result = 8
            };

            TrainData trainData9 = new TrainData(5, 3)
            {
                Data = new double[5, 3] {
                { 1.0, 1.0, 1.0 },
                { 1.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 },
                { 0.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0 }
                       }.MatrixToArray()
            ,
                Result = 9
            };

            nn.TrainNetwork(10000, new TrainData[10] { trainData0, trainData1, trainData2, trainData3, trainData4, trainData5, trainData6, trainData7, trainData8, trainData9 });

            nn.FeedForward( trainData4.Data).ShowArray();

        }
    }
}
