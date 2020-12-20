using System;

namespace SimpleNN.Models
{
    public class Model
    {
        public Model()
        {


        }

        public InputLayer Input { get; set; }

        public HiddenLayer HiddenLayer1 { get; set; }

        public OutputLayer OutputLayer { get; set; }

        public void InitModel()
        {
            Input = new InputLayer(5, 3,
                new int[5, 3]
                {
                    { 1, 1, 1 },
                    { 0, 0, 1 },
                    { 0, 0, 1 },
                    { 0, 0, 1 },
                    { 0, 0, 1 }
                });

            HiddenLayer1 = new HiddenLayer(7, 15,
                new int[7, 15]
                {
                    { 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                    { -1, -1, 1, -1, -1, 1, -1, -1, 1, -1, -1, -1, -1, -1, -1 },
                    { -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, 1, -1, -1, 1 },
                    { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1 },
                    { -1, -1, -1, -1, -1, -1, 1, -1, -1, 1, -1, -1, 1, -1, -1 },
                    { 1, -1, -1, 1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1 },
                    { -1, -1, -1, -1, -1, -1, 1, 1, 1, -1, -1, -1, -1, -1, -1 }
                });

            OutputLayer = new OutputLayer(10, 7,
                new int[10, 7]
                {
                    { 1, 1, 1, 1, 1, 1, -1 },
                    { -1, 1, 1, -1, -1, -1, -1 },
                    { 1, 1, -1, 1, 1, -1, 1 },
                    { 1, 1, 1, 1, -1, -1, 1 },
                    { -1, 1, 1, -1, -1, 1, 1 },
                    { 1, -1, 1, 1, -1, 1, 1 },
                    { 1, -1, 1, 1, 1, 1, 1 },
                    { 1, 1, 1, -1, -1, -1, -1 },
                    { 1, 1, 1, 1, 1, 1, 1 },
                    { 1, 1, 1, 1, -1, 1, 1 }
                });

        }



        public int[] Activation(int[] input, int[,] weights, int bias)
        {
            int row = weights.GetLength(0);
            int column = weights.GetLength(1);
            int[] res = new int[row];

            for (int i = 0; i <= row - 1; i++)
            {
                for (int j = 0; j <= column - 1; j++)
                {
                    res[i] += weights[i, j] * input[j];
                }
                res[i] = Math.Max(res[i] + 2, 0);
                //res[i] = res[i] < 0 ? -1 : 1;
            }

            return res;
        }
    }


}
