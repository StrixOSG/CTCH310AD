/*
 * Name: 			Matthew Hamilton
 * Student Number: 	200361163
 * Date:			Feb.6, 2018
 * Lab:				Lab 4 (AI)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conversation : MonoBehaviour {

	public int iq = 5;				//Initialize iq of npc
	public GameObject player;
	private Vector3 origPos;
	public Vector3 currPlayerPos = new Vector3(0,0,0);

	void Start(){

		Greet ();
		currPlayerPos = player.transform.position;
		origPos = transform.position;

	}

	void Greet(){

		switch(iq){

		case 5:
			print ("Why hello there! Would you like to discuss quantum mechanics, good sir/madam!?");
			break;	
		case 4:
			print ("Hello and good day!");
			break;
		case 3:
			print ("Whaddya want, scrub?!");
			break;
		case 2:
			print ("Brog angery! Brogg smash face!");
			break;
		case 1:
			print ("Bleb pffffff grrrrrr *farts*!");
			break;
		default:
			print ("Incorrect IQ Level -- try again. ");
			break;

		}

	}

	void Attack(){

		currPlayerPos = player.transform.position;

		switch (iq) {

		case 5:
			print ("You stepped into my luxuriously spacious collider, now you must pay the price!");
			break;

		}

		if (currPlayerPos.x < transform.position.x) {

			transform.position = new Vector3(transform.position.x - 1f, transform.position.y, transform.position.z);

		}else{

			transform.position = new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z);

		}

		if (currPlayerPos.z < transform.position.z) {

			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1f);

		}else{

			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1f);

		}



	}

	void Idle(){

		if (origPos.x < transform.position.x) {

			transform.position = new Vector3(transform.position.x - 1f, transform.position.y, transform.position.z);

		}else{

			transform.position = new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z);

		}

		if (origPos.z < transform.position.z) {

			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1f);

		}else{

			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1f);

		}

	}

	void OnTriggerEnter(){

		Attack ();

	}

	void OnTriggerExit(){

		Idle ();

	}

}
