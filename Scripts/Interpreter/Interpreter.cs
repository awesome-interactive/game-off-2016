using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Interpreter : MonoBehaviour {

	public List<InstructionInterface> InstructionSet;
	public string program;
	private int currentLine;
	private List<ProgramLine> programLines;

	// Use this for initialization
	void Start () {
		string[] lines = this.program.Split('\n');
		ProgramLine lineObject;
		foreach(string line in lines) {
			lineObject = new ProgramLine(line);
			this.programLines.Add(lineObject, this.InstructionSet);
		}
		//string[] lines = Regex.Matches(this.program, @"\[.*?\]").Cast<Match>().Select(m => m.Value).ToArray();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void processProgram () {
	
	
	}
		
}
