using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor2Controller : MonoBehaviour {
	public GameObject l2obstacle;
	public GameController gc;
	// Use this for initialization
	void Start () {

	}


	void OnMouseEnter() {
		if (gc.level == 4) {
			gc.setMaze (4.5);
		}
	}
}