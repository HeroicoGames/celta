﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseposition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 x = Input.mousePosition;
        x.z = 2.6f;
        this.transform.position = Camera.main.ScreenToWorldPoint(x);
    }
}
