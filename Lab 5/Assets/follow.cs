/*
 * Program: 		follow.cs
 * Author: 			Matthew Hamilton
 * Date:			Feb.13, 2018
 * Class:			CTCH 310AD
 * Description:		This script makes an object follow the player
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

	public float speed;
	public GameObject player;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		float distance = Vector3.Distance (player.transform.position, transform.position);

		Vector3 localPosition = transform.position - player.transform.position;
		localPosition = localPosition.normalized;

		if (distance < 5) {

			transform.Translate (localPosition.x * Time.deltaTime * speed, 
				0f, 
				localPosition.z * Time.deltaTime * speed);

		}

	}
}
