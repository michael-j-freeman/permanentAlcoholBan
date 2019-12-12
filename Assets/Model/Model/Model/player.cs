using System;

/*class defining player attributes and functions to update said attributes */

public class Player
{
	string name;
	int drunk_level = 0; //out of 100
	int stamine = 100; //goes down when used

	public void update_drunk_level(Player player)
		/*Increase player's drunk level by 10 unless at 100 already*/	
	{
		if (player.drunk_level < 90)
		{
			player.drunk_level += 10;
		}
		else
		{
			player.drunk_level = 100;
		}
	}

	public void update_stamina(Player player)
	/*Increase stamina upon drinking or waiting long enough,
	 decrease upon sprinting*/
	{

	}



}
