using SimpleNN.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNN.Models
{
    public class InputLayer
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public int NodeCount => Row * Column;

        public double[,] Input { get; set; }

        public double[] InputNodes { get; set; }

        public InputLayer(int row, int column, double[,] input)
        {
            this.Row = row;
            this.Column = column;

            Input = input;
            InputNodes = new double[NodeCount];

            int z = 0;
            for (int i = 0; i <= Row - 1; i++)
            {
                for (int j = 0; j <= Column - 1; j++)
                {
                    InputNodes[z++] = input[i, j];
                }
            }
        }

        public InputLayer()
        {
            this.Row = 0;
            this.Column = 0;
            Input = new double[0, 0];
            InputNodes = new double[0];
        }
    }
}
