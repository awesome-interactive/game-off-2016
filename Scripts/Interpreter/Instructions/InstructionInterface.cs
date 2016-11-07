using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public interface InstructionInterface
{
	//name of instruction
	String name {get;}
	//instruction arguments
	List<string> args {get;set;}
	//this will be called the first time an instruction is run
	void startAction(List<string> args, GameObject gameObject,Action callback);
	//this will be called for all subsequent runs
	//call the callback to go to the next line
	bool runAction ();

}


