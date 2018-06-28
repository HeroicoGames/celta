using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

	Text text;
	public float timeLeft = 50f;
	[HideInInspector]
	public bool isOver = false;

	// Use this for initialization
	void Start () {
		text = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isOver == false) {
			timeLeft -= Time.deltaTime;
			if (timeLeft < 0) {
				text.text = "Tiempo restante : " + Mathf.Round (0);			
			} else
				text.text = "Tiempo restante : " + Mathf.Round (timeLeft);
		} 

		if (timeLeft <= 0 && isOver == false) {
			isOver = true;
			GameObject.Find ("UI").GetComponent <UIManager> ().ActivateLoserWindow ();
		}
	}
}
