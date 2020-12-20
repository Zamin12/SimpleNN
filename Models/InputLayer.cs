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

        public int[,] Input { get; set; }

        public int[] InputNodes { get; set; }


        public InputLayer(int row, int column, int[,] input)
        {
            this.Row = row;
            this.Column = column;

            Input = input;
            InputNodes = new int[NodeCount];

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
            Input = new int[0, 0];
            InputNodes = new int[0];
        }
    }
}
