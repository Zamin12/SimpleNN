using System;
using SimpleNN.Models;

namespace SimpleNN
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Model model = new Model();

            model.InitModel();

            var res = model.Activation(model.Input.InputNodes, model.HiddenLayer1.Weights, 0);

            var res1 = model.Activation(res, model.OutputLayer.Weights, 0);

            Console.ReadLine();
            //while (s != 4)
            //{
            //    Console.WriteLine("MENU \n 1. Create new model \n 2. Add Input: \n 3. Process model \n 4.Exit");
            //    int.TryParse(Console.ReadLine(), out s);
            //    switch (s)
            //    {
            //        case 1: model.InitModel(); break;
            //        case 2: break;
            //        case 3: model.Activation(); break;
            //        default:
            //            break;
            //    }
            //    Console.Clear();
            //}

        }

    }
}
