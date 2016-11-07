using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class MoveInstruction : InstructionInterface {

	string name {
		get {
			return "MOVE";
		}
	}

	private Action callback;
	private List<string> args;
	private GameObject gameObject;

	void startAction (List<string> args, GameObject gameObject, Action callback) {
		this.args = args;
		this.gameObject = gameObject;
	}


	//return true when finished
	bool runAction () {


		this.callback(-1);
	}


}