using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed;
	public 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int horizontal = 0;     //Used to store the horizontal move direction.
		int vertical = 0;       //Used to store the vertical move direction.


		//Get input from the input manager, round it to an integer and store in horizontal to set x axis move direction
		horizontal = (int) (Input.GetAxisRaw ("Horizontal"));

		//Get input from the input manager, round it to an integer and store in vertical to set y axis move direction
		vertical = (int) (Input.GetAxisRaw ("Vertical"));

		transform.Translate (new Vector3 (horizontal, vertical, 0.0f) * speed);
	}

//	void OnCollisionEnter2D(Collision2D coll) {
//		if (coll.gameObject.CompareTag ("Maze"))
//		{
//			transform.position = new Vector3 (-7.5f, -5.5f, 0.0f);
//		}
//	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Maze"){
			// this rigidbody or CharacterController entered a trigger tagged Wall
			transform.position = new Vector3 (-7.5f, -5.5f, 0.0f);
		}
	}
}
