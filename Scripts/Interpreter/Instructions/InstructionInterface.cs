using System;


public interface InstructionInterface
{
	String name {get;}
	int args {get;}
	Action action ();

}


