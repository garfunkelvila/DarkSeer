﻿using Chaotic_Seer.NEAT;
using Chaotic_Seer.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chaotic_Seer.NN {
	class ConnectionNeuron : IConnection {
		public INode In { get; set; }
		public INode Out { get; set; }
		public float Weight { get; set; }
		public int Innovation { get; set; }

		public ConnectionNeuron(ConnectionNeuron gene) {
			In = gene.In;
			Out = gene.Out;
			Innovation = gene.Innovation;
			Weight = gene.Weight;
		}

		public override bool Equals(object obj) {
			if (!GetType().Equals(obj.GetType())) return false;

			ConnectionNeuron other = obj as ConnectionNeuron;
			return
				In.Equals(other.In) &&
				Out.Equals(other.Out);
		}

		public override int GetHashCode() {
			return In.Innovation * Parameters.MaxNodes + Out.Innovation;
		}
    }
}
