using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour 
{
	public List<GameObject> minions;
	protected int health;
    protected int atkDmg;
	static gameManager instance;

      public static gameManager GetInstance()
    {
        if (instance == null)
        {
            instance = new gameManager();
        }
        return instance;
    }	
	
	void Start()
	{
		instance = this;
		
	}
	
}
