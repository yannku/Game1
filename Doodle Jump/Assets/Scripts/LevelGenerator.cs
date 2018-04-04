﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {
	//reference to the platform
	public GameObject platformPrefab;
	//no. of platforms that needs to be stored
	public int numberOfPlatforms = 200;
	//stores width of the level
	public float levelWidth = 3f;
	public float minY = 1f;
	public float maxY = 2.5f;

	// Use this for initialization
	void Start () {
		Vector3 spawnPosition = new Vector3();
		for (int i = 0; i < numberOfPlatforms; i++)
		{
			spawnPosition.y += Random.Range(minY, maxY);
			spawnPosition.x = Random.Range(-levelWidth, levelWidth);
			Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
