using System;


public class Player
{
	public int drunk_level = 0; //out of 100
	public int stamine = 100; ///goes down when used

	static void Main(String[] args)
    {
		Player finn = new Player();
		Console.WriteLine(finn.drunk_level);

		Console.ReadLine();
    }

}
