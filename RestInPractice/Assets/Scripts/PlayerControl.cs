/*By: Ryan Vega
 Summery: This script gives the player control over the main character
 Edited: 5/25/18
 Tested: Unity 2018.2.6f
 */

//Required for using the Unity Engine
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour, iDestructable
{
    public float speed = 2.0f;
    public GameObject player;
    //This is for the placement of an enemy
    public GameObject[] target;
	
	
	static public PlayerControl instance = null;
	void Awake()
	{
		instance = this;
	}

    void Start()
    {
        target = GameObject.FindGameObjectsWithTag("Enemy");
    }

    private void Update()
    {

    }
    private void FixedUpdate()
    {
        Touch touch = Input.GetTouch(0);
        Vector2 pos = touch.position;

        if (Input.touchCount == 1)
        {       
            float ratio = ((float)Screen.width) / Screen.height;
            
            if (pos.x < (pos.y * ratio))
            {
                if (pos.x < ((Screen.height - pos.y) * ratio))
                {
                    transform.Translate(Vector2.left * speed * Time.deltaTime);
                    Debug.Log("Left!"); 
                }
                else
                {
                    transform.Translate(Vector2.up * speed * Time.deltaTime);
                    Debug.Log("Up!");
                }
            }
            else
            {
                if ((Screen.width - pos.x) < (pos.y * ratio))
                {
                    transform.Translate(Vector2.right * speed * Time.deltaTime);
                    Debug.Log("Right!");
                }
                else
                {
                    transform.Translate(Vector2.down * speed * Time.deltaTime);
                    Debug.Log("Down!");
                }
            }
          
        }

    }
	void iDestructable.iDie()
	{
		Destroy(gameObject);
	}	
}