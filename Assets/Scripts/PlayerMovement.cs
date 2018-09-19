using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

//this is a reference to the rigidbody component called "rb".
public Rigidbody rb;

//public float forwardForce = 1000f;
public float movingForce = 600f; 
public float jumpForce = 60000f;
	// Use this for initialization.
	void Start () { 
		//this is a print		
		Debug.Log("Hello, world!");
	}	
	// Update is called once per frame.
	//we marked this as "fixed" update because we are using it to mess with physics.	
	void FixedUpdate () {
		//add a forward force
		//	rb.AddForce(0,0,forwardForce * Time.deltaTime);
		//jumping feels weird, fix that.
		//moving around the world feels slow, fix that too.w
		if(Input.GetKey("space")){
				rb.AddForce(0,jumpForce * Time.deltaTime,0);
		}
		if(Input.GetKey("d")){
				rb.AddForce(movingForce * Time.deltaTime,0,0);
		}
		if(Input.GetKey("a")){
				rb.AddForce(-movingForce * Time.deltaTime,0,0);
		}
		if(Input.GetKey("w")){
				rb.AddForce(0,0,movingForce * Time.deltaTime);
		}	
		if(Input.GetKey("s")){
				rb.AddForce(0,0,-movingForce * Time.deltaTime);
		}
	}
}