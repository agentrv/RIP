using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScytheScript : MonoBehaviour
{

    public int damage;
    public Rigidbody2D rb;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject);
    }

    //Called when the Sythe overlaps the Enemy
    void OnCollisionEnter(Collision collision)
    {
        iDestructable other = collision.gameObject.GetComponent<iDestructable>();
        if (other != null)
        {
            other.iDie();
            Destroy(gameObject);
        }
    }
}
