using System;


public class Player
{
	public int drunk_level = 0; //out of 100
	public int stamine = 100; //goes down when used
	public int sprint_speed = 50; //Increased after drinking and decreased when stamina is 0

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

	public void update_sprint_speed(Player player)
	/*After drinking, sprint_speed is increased.
	 If stamina is 0, sprint speed == walk speed (or maybe jsut over)*/
	{

	}



}
