using System;

public class Npc
{
	public Array npc_location = new double[3]; //x, y, and z coordinates (probs dont need this, comes in movement script too)
	int party_location; //location of party npc can direct player to
	bool in_dialogue = false;
	int friendship_level = 0; //out of 10?

	/*
	public void movement()
	{
//this doesnt need to be here, theres another script for that
//will need to make some of these vaiables public ect so the movement script can acess it
	}
*/
	
	//these will need to be modified to accept story engine parameters 
	//blocked atm by that not existing
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
