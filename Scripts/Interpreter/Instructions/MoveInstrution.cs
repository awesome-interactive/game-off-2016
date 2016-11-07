using UnityEngine;
using System.Collections;

public class MoveInstruction : InstructionInterface {

	string name {get;}
	int args {get;}

	private MoveInstruction () {
		this.name = "MOVE";
		this.args = 2;
	}

}
