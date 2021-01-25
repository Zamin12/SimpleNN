using System;

namespace SimpleNN.Core.Models
{
    public struct TrainData
    {
        public double[] Data { get; set; }
        public int Result { get; set; }

        public TrainData(int row, int column)
        {
            Result = 0;
            Data = new double[row * column];
        }
    }
}
