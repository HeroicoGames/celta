using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celta : MonoBehaviour {

	public int points = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (points == 10) {
			GameObject.Find ("UI").GetComponent <UIManager> ().ActivateWinnerWindow ();
			GameObject.Find ("Count Down").GetComponent <CountDown> ().isOver = true;
		}
	}
}
