using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public int level;

	public Text levelText;
	public GameObject maze;
	public GameObject goal;
	public GameObject start;

	public GameObject msg;
	public GameObject end;

	public GameObject sensor1;
	public GameObject sensor2;
	public GameObject obstacle1;

	public GameObject maze3;
	public GameObject maze4;
	public GameObject maze5;
	public
	// Use this for initialization
	void Start () {
		level = 1;
		//end.SetActive (false);
		setUp ();
	}

	public void setMaze(double lvl){
		if (lvl == 3) {
			maze.SetActive (false);
			maze3.SetActive (true);
		} else if (lvl == 4) {
			sensor1.SetActive (false);
			maze.SetActive (false);
			maze4.SetActive (true);
			sensor2.transform.position = new Vector3 (259.6f, 216.6f, 0.0f);
			sensor2.transform.localScale = new Vector3 (7.12f, 7.96f, 1);
			sensor2.SetActive (true);
		} else if (lvl == 4.5) {
			maze4.SetActive (false);
			maze5.SetActive (true);
		}
	}
	
	//Level up
	public void levelUp () {
		level++;
	}

	//Set up before level begins
	public void setUp(){
		if (level == 5) {
			end.SetActive (true);
		} else {
			end.SetActive (false);
			goal.SetActive (false);
			start.SetActive (true);
			msg.SetActive (true);
			maze.SetActive (true);
			maze3.SetActive (false);
			maze4.SetActive (false);
			maze5.SetActive (false);
			sensor1.SetActive (false);
			sensor2.SetActive (false);
			obstacle1.SetActive (false);
			levelText.text = "";
		}
	}


	//Called when level is loaded
	public void startLevel(){

		levelText.text = "Level: " + level;
		goal.SetActive (true);
		start.SetActive (false);
		msg.SetActive (false);

		Debug.Log(level);
		if (level == 2) {
			Debug.Log("it works!");
			sensor1.transform.position = new Vector3 (575.0f, 71.3f, 0.0f);
			sensor1.transform.localScale = new Vector3 (12.75f, 7.66f, 1);
			sensor1.SetActive (true);
		}
		else if (level == 3) {
			sensor1.transform.position = new Vector3 (562.1f, 183.6f, 0.0f);
			sensor1.transform.localScale = new Vector3 (6.72f, 7.85f, 1);
			sensor1.SetActive (true);
		}
		else if (level == 4) {
			sensor1.transform.position = new Vector3 (290.1f, 71.8f, 0.0f);
			sensor1.transform.localScale = new Vector3 (6.72f, 7.85f, 1);
			sensor1.SetActive (true);
		}
	}	


}
