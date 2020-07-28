﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chaotic_Seer.Util {
	interface INode {
		NeuronTypes Type { get; set; }
	}
	public enum NeuronTypes {
		Sensor = 1,
		Bias = 2,
		Inter = 3,
		Memory = 4,
		Motor = 5
	}
}
