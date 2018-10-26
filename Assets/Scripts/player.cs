using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour

    {

    public float speed = 10;
    public Rigidbody2D physicsBody;
    public string horizontalAxis = "Horizontal";



	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        //get axis input from unity
        float leftRight = Input.GetAxis(horizontalAxis);

        //create direction vecto from axis input
        Vector2 direction = new Vector2(leftRight, 0);

        //make direction vector lenghth 1
        direction = direction.normalized;

        //calculate the velocity 
        Vector2 velocity = direction * speed;
        velocity.y = physicsBody.velocity.y;

        //give the velocity to the rigidbody
        physicsBody.velocity = velocity;

	}
}
