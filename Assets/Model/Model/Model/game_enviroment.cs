using System;


/* Main class through which all current game data is stored and can be updated */

public class game_environment
{
	public Array player_location = new double[3]; //x, y, and z coordinates
	public int[] all_parties = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //all possible party locations
	public int[] parties = new int[5]; //parties selected for individual game


	public game_environment()
    {
		//select party locations
		Random rng = new Random();
		while (parties.Length < 5)
		{
			int new_party = rng.Next(0, 10);
			int contains = Array.IndexOf(parties, all_parties[new_party]);
			if (contains != -1)
			{
				parties.Add(new_party);
			}
		}

    }


}
