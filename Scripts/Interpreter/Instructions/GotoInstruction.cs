using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class MoveInstruction : InstructionInterface {

	string name {
		get {
			return "GOTO";
		}
	}

	private Action callback;
	private List<string> args;
	private GameObject gameObject;

	void startAction (List<string> args, GameObject gameObject, Action callback) {
		string lineString = args[0];
		int lineNo = Int32.Parse(lineString);
		return lineNo;
	}


	//return true when finished
	bool runAction () {
		//do nothing - realistically, this will never be called
	}


}