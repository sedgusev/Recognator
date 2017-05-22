using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Layer
    {
        //private double[,] nero = new double[7,4];
        private double[,,] WEIGHT;
        private double[,,] nero;
        private List<double[,,]> list = new List<double[,,]>();

        public Layer(double[,] input)
        {
            WEIGHT = new double[20, input.GetLength(0), input.GetLength(1)];
            //WEIGHT = JsonConvert.DeserializeObject<List<double[,,]>>(System.IO.File.ReadAllText("weights.txt")).First();
            nero = new double[20, 4, 7];

            for (int m = 0; m < 20; m++)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        for (int s = 1; s < 6; s++)
                        {
                            for (int t = 1; t < 6; t++)
                            {
                                nero[m, i, j] += WEIGHT[m, s, t] * input[(i - 1) + s, j + t];
                                //nero[m, i, j] = 1.7159 * Math.Tanh(nero[m, i, j] * 2 / 3);
                            }
                        }
                    }
                }
            }
        }

        public double[,,] GetNero { get { return nero; } private set { nero = null; }  }

        //public string GetWeights { get { return JsonConvert.SerializeObject(list); } private set { list = null; } }

    }
}
