using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


public class Interpreter : MonoBehaviour {

	public List<InstructionInterface> instructionSet;
	public string program;
	private int currentLineIndex;
	private List<ProgramLine> programLines;
	private Action nextStep();
	private InstructionInterface currentInstruction;

	// Use this for initialization
	void Start () {

		this.nextStep = (int lineNo) => {
			ProgramLine line;
			if(lineNo == -1) {
				line = this.programLines[this.currentLineIndex++];
			} else {
				line = this.programLines[this.findLineIndex(lineNo)];
			}

			this.currentInstruction = this.instructionSet[line.instructionIndex];
			this.currentInstruction.startAction(line.args,this.gameObject,this.nextStep);
		};


	
	}
	
	// Update is called once per frame
	void Update () {
		this.currentInstruction.runAction();
	}

	void processProgram () {
		string[] lines = this.program.Split('\n');
		ProgramLine lineObject;
		foreach(string line in lines) {
			lineObject = new ProgramLine(line);
			this.programLines.Add(lineObject, this.InstructionSet);
		}
	}

	int findLineIndex (int lineNo) {

	}
		
}
