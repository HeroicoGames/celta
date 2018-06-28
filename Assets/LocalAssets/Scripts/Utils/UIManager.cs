using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

	public GameObject WinnerWindow;
	public GameObject LoserWindow;

	public void ActivateWinnerWindow () {
		WinnerWindow.SetActive (true);
	}

	public void ActivateLoserWindow () {
		LoserWindow.SetActive (true);
	}

	public void DeactivateWinnerWindow () {
		WinnerWindow.SetActive (false);
	}

	public void DeactivateLoserWindow () {
		LoserWindow.SetActive (false);
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
