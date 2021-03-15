using System;

public class GameManager
{
	private static GameManager instance;
	
	private GameManager() {}
	
	public static GameManager Instance
	{
		get 
		{
			if (instance == null)
			{
				instance = new GameManager();
			}
			return instance;
		}
	}


	public bool check;
	public bool b_isRateCall;
	public int tool,fr,lmo,bl,p,Sceconds;
	public string Scene_name;
}