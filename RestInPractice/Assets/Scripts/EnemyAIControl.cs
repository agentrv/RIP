/*By: Ryan Vega
 Summery: This Script gives the ability for Objects to be destroyed.
 Edited: 10/25/18
 Tested: Unity 2018.2.6f
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIControl : iDestructable 
{


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        iDestructable other = collision.gameObject.GetComponent<iDestructable>();
        if (other != null)
        {
            other.takeDamage();
            other.iDie();            
        }
    }

    public void iDie()
    {

    }

}
