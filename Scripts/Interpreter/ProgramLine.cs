using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class ProgramLine {

	public int lineNo {get;set;}
	public int instructionIndex {get;set;}
	public List<string> args {get;set;}

	public ProgramLine (string Line, List<InstructionInterface> instructionSet) {
		
	}
}


