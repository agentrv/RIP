using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	/* 
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
	*/
}
