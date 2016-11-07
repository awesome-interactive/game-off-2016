using UnityEngine;
using System;
using System.Collections;

public class MoveInstruction : InstructionInterface {

	string name {
		get {
			return "MOVE";
		}
	}
	int args {
		get {
			return 2;
		}
	}

	Action action () {
		return () => {

		};
	}


}