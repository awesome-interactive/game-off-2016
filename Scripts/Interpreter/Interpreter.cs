using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Interpreter : MonoBehaviour {

	public List<InstructionInterface> Instructions;
	public string program;
	private int currentLine;
	private List<string> programLines;

	// Use this for initialization
	void Start () {
		string[] lines = this.program.Split('\n');
		foreach(string line in lines) {

		}
		//string[] lines = Regex.Matches(this.program, @"\[.*?\]").Cast<Match>().Select(m => m.Value).ToArray();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void processProgram () {

	}
}
