using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScytheScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    //Called when the Sythe overlaps the Enemy
    void OnCollisionEnter(Collision collision)
    {
        iDestructable other = collision.gameObject.GetComponent<iDestructable>();
        if (other != null)
        {
            other.iDie();
        }
    }
}
