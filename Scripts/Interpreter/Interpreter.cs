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
	public bool isRunning = false;

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

		this.processProgram();

	}
	
	// Update is called once per frame
	void Update () {
		if(this.isRunning) {
			this.currentInstruction.runAction();
		}

	}

	void processProgram () {
		string[] lines = this.program.Split('\n');
		ProgramLine lineObject;
		foreach(string line in lines) {
			lineObject = new ProgramLine(line);
			this.programLines.Add(lineObject, this.instructionSet);
		}
	}

	int findLineIndex (int lineNo) {
		for(int i = 0; i < this.programLines.Count; i++) {
			if(this.programLines[i].lineNo == lineNo) {
				return i;
			}
		}
		return -1;
	}

		
}
