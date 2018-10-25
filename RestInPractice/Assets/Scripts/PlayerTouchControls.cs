using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouchControls : MonoBehaviour

    {
    public GameObject PlayerCharacter;
    Vector3 touchpos;
    public Vector3 playerpos;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Touch touch = Input.GetTouch(0);
        touchpos = Camera.main.ScreenToWorldPoint(touch.position);
        PlayerCharacter.GetComponent<Transform>().position = playerpos;
        playerpos = new Vector2(touchpos.x, touchpos.y);
        
    }
}
