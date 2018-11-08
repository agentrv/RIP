/*By: Ryan Vega
 Summery: This Script gives the ability for Objects to be destroyed.
 Edited: 10/25/18
 Tested: Unity 2018.2.6f
 */

using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EnemyAIControl : MonoBehaviour, iDestructable
{
    public int health = 5;
    public int damage;
    public GameObject enemy;

    // Use this for initialization
    void Start()
    {
        enemy = GetComponent<GameObject>(); 
    }

    // Update is called once per frame
    void Update()
    {
		PlayerControl.instance.transform.position
    }

    void OnCollisionEnter(Collision collision)
    {
        iDestructable other = collision.gameObject.GetComponent<iDestructable>();
        if (other != null)
            other.iDie();
    }

    void iDestructable.iDie()
    {
        if (health > 0)
        {
            health--;
        }
        else
        {
            Destroy(enemy);
        }
    }
}
