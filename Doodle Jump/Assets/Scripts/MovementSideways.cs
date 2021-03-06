﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSideways : MonoBehaviour {
	public float speed = 10f;
	//float leftBound;
	//float rightBound;
	public float radius = 0f;
	int direction = -1;

	// Use this for initialization
	void Start () {
		
		//leftBound = Camera.main.ViewportToWorldPoint(Vector3.zero).x;
		//rightBound = Camera.main.ViewportToWorldPoint(Vector3.one).x;
		
	}
	
	// Update is called once per frame
	//movement of the platforms by using the level width 
	void Update () {
		transform.Translate(Vector3.right * direction * speed * Time.deltaTime);

		if(transform.position.x < -LevelGenerator.levelWidth + radius || transform.position.x > LevelGenerator.levelWidth - radius)
		{
			direction *= -1;
		}
	}
}
