/*
 * Name: 			Matthew Hamilton
 * Student Number: 	200361163
 * Date:			Feb.6, 2018
 * Lab:				Lab 4 (Terrain Generation)
 * 
 * 
 * /

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hello : MonoBehaviour {
	// Use this for initialization
	void Start () {

		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;

	}
	
	// Update is called once per frame
	void Update () {

		move();											//Call Movement Function

	}

	void move(){

		//Movement Keys
		if (Input.GetKey (KeyCode.W)) {

			transform.Translate (0f, 0f, 0.1f);			//Move Forward e.g 0.1 in the Z direction

		} else if (Input.GetKey (KeyCode.A)) {

			transform.Translate (-0.1f, 0f, 0f);		//Move Left e.g. -0.1 in the X direction

		} else if (Input.GetKey (KeyCode.D)) {

			transform.Translate (0.1f, 0f, 0f);			//Move Right e.g. 0.1 in the X direction

		} else if (Input.GetKey (KeyCode.S)) {

			transform.Translate (0f, 0f, -0.1f);		//Move Backward e.g. -0.1 in the Z direction

		} else if (Input.GetKey (KeyCode.Space)) {

			transform.Translate (0f, 0.1f, 0f);			//Move Up e.g. 0.1 in the Y direction

		} else if (Input.GetKey (KeyCode.LeftControl)) {

			transform.Translate (0f, -0.1f, 0f);		//Move Down e.g. -0.1 in the Y direction

		}

		//Look Direction Keys
		if(Input.GetKey(KeyCode.RightArrow)){


			transform.Rotate(0f,1f,0f);					//Turn Right e.g. 1f in the Y Direction

		} else if(Input.GetKey(KeyCode.LeftArrow)){


			transform.Rotate(0f,-1f,0f);				//Turn Left e.g. -1f in the Y Direction

		}

		float h = Input.GetAxis ("Mouse X") * 3.0f;		//Left and right mouse direction
		float x = Input.GetAxis ("Mouse Y") * 3.0f;		//Up and down mouse direction
		transform.Rotate(-x, h, 0f);						//Update mouse look direction

	}

}
