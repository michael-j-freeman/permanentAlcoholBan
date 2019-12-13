using System;

public class Map
{
	public int[] all_parties = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //all possible party locations
	public int[] parties = new int[5]; //parties selected for individual game
	public int[] cop_car_locations; //positions of cop cars on the map


	public Map()
	{
		//select party locations
		Random rng = new Random();
		while (parties.Length < 5)
		{
			int new_party = rng.Next(0, 10);
			int contains = Array.IndexOf(parties, all_parties[new_party]);
			if (contains != -1)
			{
				//parties.add(new_party);
			}
		}

	}

}
