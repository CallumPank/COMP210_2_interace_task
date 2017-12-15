using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 3f;
    public float maxSpeed = 5f;
    public float minSpeed = 1f;
    private Vector3 targetPosition;
    public bool isWalking;
    private Vector3 cursorPosition;

  

	// Use this for initialization
	void Start ()
    {
        isWalking = true;

        
    }


    private void PlayerMoving()
    {
        //PLayer will head towards where the cursor of the hololens is
        cursorPosition = GameObject.Find("Anchor_Cursor").transform.position;
        targetPosition = cursorPosition;
        targetPosition.y = transform.position.y;

        //will look at cursor and move towards it
        transform.LookAt(targetPosition);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, (speed / 5f) * Time.deltaTime);

    }


    // Update is called once per frame
    void Update () {

        if (isWalking)
        {
            PlayerMoving();
            
        }

        

    }
}
