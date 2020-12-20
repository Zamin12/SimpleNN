using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNN.Models
{
    public class Weight
    {
        public int[,] Weights { get; set; }
        public int[] Bias { get; set; }
    }
}
