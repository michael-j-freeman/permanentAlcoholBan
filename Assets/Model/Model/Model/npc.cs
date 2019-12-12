using System;

public class Npc
{
	public Array npc_location = new double[3]; //x, y, and z coordinates
	int party_location; //location of party npc can direct player to
	bool in_dialogue = false;
	int friendship_level = 0; //out of 10?

	public void movement()
	/*move npc*/
	{

	}

	public String call_out(String input)
	/*call out in response to input string*/
	{
		Console.WriteLine(input);
	}

	public void cops()
	/*respond to cops being nearby*/
	{
		call_out("Shit, cops!");
	}

}
