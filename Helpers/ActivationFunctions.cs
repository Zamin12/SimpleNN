using System;
namespace SimpleNN.Helpers
{
    public static class ActivationFunctions
    {

        public static Func<double, double> Sigmoid = (double x) => { return 1 / (1 + Math.Exp(-x)); };
    }
}
