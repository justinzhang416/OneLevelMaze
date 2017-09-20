using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorController : MonoBehaviour {
	public GameObject l2obstacle;
	public GameController gc;
	public float timeLeft = 0;
	public bool timerActive = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timerActive) {
			timeLeft = timeLeft - Time.deltaTime;
			Debug.Log(timeLeft);
			if (timeLeft < 0) {
				l2obstacle.SetActive (false);
				timerActive = false;
			}
		}
	}

	void OnMouseEnter() {
		if (gc.level == 2) {
			l2obstacle.transform.position = new Vector3 (460.0f, 73.3f, 0.0f);
			l2obstacle.SetActive (true);
			timeLeft = 5;
			timerActive = true;
		}
		else if (gc.level == 3) {
			Debug.Log ("level 3 sensor detected");
			gc.setMaze (3);
		}
		else if (gc.level == 4) {
			gc.setMaze (4);
		}
	}
}
