﻿using UnityEngine;
using System.Collections;

public class mover2 : MonoBehaviour {

	private Transform startPoint2, endPoint2;
	
	public float percentage;
	public float speed = 2;
	private int direction;

	// Use this for initialization
	void Start () {

		startPoint2 = GameObject.Find ("startPoint2").transform;
		endPoint2 = GameObject.Find ("endPoint2").transform;
		direction = 1;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = Vector3.Lerp (startPoint2.position, endPoint2.position, percentage);	
		percentage += Time.deltaTime/speed * direction;
		
		if ((percentage > 1) || (percentage < 0)) {
			direction = -direction;
			percentage = Mathf.Clamp (percentage, 0, 1);
		}

	}
}
