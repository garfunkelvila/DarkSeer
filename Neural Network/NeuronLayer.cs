﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ALLOW SOMEHING LIKE THIS, ISOLATED LAYERS
// Just realized that, what I want to do is a CNS
// *-*-*-*-*-*-*-*-*-*
// *-*-*-*-*-*-*-*-*-*-*
// *-*-*-*-*-*-*-*-*-*-*-*-*-*
//         *-*-*-*-*-*-*-*-*-*
// *-*-*-*-*-*-*-*-*-*-*-*-*-*
// *-*-*-*-*-*-*-*-*-*-*-*-*-*
// *-*-*-*-*-*-*-*-*-*-*-*-*-*
//         *-*-*-*-*-*-*-*-*-*
// *-*-*-*-*-*-*-*-*-*-*-*-*-*
// *-*-*-*-*-*-*-*-*-*-*
// *-*-*-*-*-*-*-*-*-*
namespace Neural_Network {
    public enum NeuronTypes {
        Sensory = 1,
        Inter = 2,
        Motor = 3
    }
    /// <summary>
    /// Neuron layer or Layer group (non-existing yet) should accept one or many double and poop one or many double
    /// </summary>
    public class NeuronLayer {
        public Neuron[] neurons;
        public NeuronTypes neuronType;
        /// <summary>
        /// Creates a layer filled with neurons
        /// </summary>
        /// <param name="nCount">Neuron count</param>
        /// <param name="iCount">Input count</param>
        public NeuronLayer (int iCount, int nCount) {
            this.neurons = new Neuron[nCount];
            for (int i = 0; i < nCount; i++) {
                neurons[i] = new Neuron(iCount);
            }
        }
        public NeuronLayer (int nCount, int iCount, NeuronTypes nType = NeuronTypes.Inter) {
            this.neurons = new Neuron[nCount];
            for (int i = 0; i < nCount; i++) {
                neurons[i] = new Neuron(iCount);
            }
        }
        public NeuronLayer (int nCount, int iCount, ActivationFunctions aF = ActivationFunctions.Logistic) {
            this.neurons = new Neuron[nCount];
            for (int i = 0; i < nCount; i++) {
                neurons[i] = new Neuron(iCount, aF);
            }
        }
        //public Neuron[] neurons { get; set; }
        //public NeuronTypes neuronType { get; set; }
        //Add input
        //Add output
    }
}
