using System.Collections;
using UnityEngine;

public class hurtPlayer : MonoBehaviour, iDestructable
{

	public int playerHealth;
	
	// Use this for initialization
	void Start () 
	{
	print (playerHealth);
	}
	
	void iDestructable.iDie()
	{
		Destroy(gameObject);
	}
}
