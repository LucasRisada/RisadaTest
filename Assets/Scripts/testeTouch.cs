﻿using UnityEngine;
using System.Collections;

public class testeTouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0)
		{
			if (Input.GetTouch (0).phase == TouchPhase.Began)
				print ("Touched");
			if (Input.GetTouch (0).phase == TouchPhase.Ended)
				print ("Stopped");
		}
	}
}
