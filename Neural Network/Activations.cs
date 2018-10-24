﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network {
    enum ActivationFunctions {
        Any = 0,
        Logistic = 1,
        TanH = 2,
        ReLu = 3,
        Step = 4
    }
    abstract class Activations {
        public Random r = new Random();
        public double Sigmoid (double x) {
            return (1 / (1 + Math.Exp(-x)));
        }
        /// <summary>
        /// Based on https://en.wikipedia.org/wiki/Logistic_function
        /// </summary>
        /// <param name="x"></param>
        /// <param name="k">the steepness of the curve</param>
        /// <param name="L">the curve's maximum value</param>
        /// <param name="X0">the x-value of the sigmoid's midpoint</param>
        /// <returns></returns>
        public virtual double Sigmoid (double x, double k = 1, double L = 1, double X0 = 0.0f) {
#if DEBUG
            if (k < 0) throw new Exception("Steepness cant be negative");
            //if (L < X0) throw new Exception("maxValue is lower than midPoint");
            //if (X0 < 0.5f) throw new Exception("midPoint just dont");
#endif
            return (L / (1 + Math.Exp(-k * (x - X0))));
        }
        public double TanH (double x) {
            return ((Math.Exp(x)) - (Math.Exp(-x))) / ((Math.Exp(x)) + (Math.Exp(-x)));
        }
        /// <summary>
        /// This ReLU starts at 0.5
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double ReLU (double x) {
            return x > 0.5d ? x : 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double Step (double x) {
            return x > 0.5d ? 1 : 0;
        }
        /// <summary>
        /// This one adds randomness.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="ActivationFunction"></param>
        /// <returns></returns>
        public double calcAxon (double x, ActivationFunctions ActivationFunction) {
            switch (ActivationFunction) {
                case ActivationFunctions.Any:
                    int af = r.Next(1, 3);
                    switch (af) {
                        case 1: return Sigmoid(x);
                        case 2: return TanH(x);
                        case 3: return ReLU(x);
                        case 4: return Step(x);
#if DEBUG 
                        default: throw new Exception("Please add the new AF here");
#endif

                    }
                case ActivationFunctions.Logistic: return Sigmoid(x);
                case ActivationFunctions.TanH: return TanH(x);
                case ActivationFunctions.ReLu: return ReLU(x);
                case ActivationFunctions.Step: return Step(x);
#if DEBUG
                default: throw new Exception("Activation function selection error occured");
#endif
            }
        }
    }

}