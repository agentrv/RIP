/*By: Ryan Vega
 Summery: This Script gives the ability for Objects to be destroyed.
 Edited: 10/25/18
 Tested: Unity 2018.2.6f
 */

using System.Collections;
using System;
using UnityEngine;

public class EnemyAIControl : MonoBehaviour, iDestructable
{
    public int health=5;
    public int damage;
	public float sightDistance=10;
	public float speed=5;
	public float attackDelay=2;
	
	private Vector3 pos;
	private Vector3 dir;
	

    // Use this for initialization
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
		if (PlayerControl.instance == null)
			return;

		pos = PlayerControl.instance.transform.position;
		dir = pos - transform.position;
		float len = dir.magnitude;
		dir.Normalize();
		
		if (len <= sightDistance)
		{
			dir *= speed * Time.deltaTime;
			transform.Translate(dir);
		}
    }

	void OnCollisionEnter (Collision collision) 
	{
		print("Colliding!!");
        iDestructable other=collision.gameObject.GetComponent<iDestructable>();
        if (other!=null)
        {    
		print("Pow!");
		other.iDie();
		}
		else
		{
		Debug.Log("Wimpy...");
		}
    }

    void iDestructable.iDie()
    {
        if (health > 0)
        {
            health--;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}