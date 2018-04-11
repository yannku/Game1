using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

	public GameObject[] enemyPrefab;
	//no. of platforms that needs to be stored
	public int numberOfenemies = 5;
	//stores width of the level
	public float levelWidth = 3f;
	public float minY = 1f;
	public float maxY = 2.5f;
	

	// Use this for initialization
	void Start () {
		
		Vector3 spawnPosition = new Vector3();
		for (int i = 0; i < numberOfenemies; i++)
		{
			spawnPosition.y += Random.Range(minY, maxY);
			spawnPosition.x = Random.Range(-levelWidth, levelWidth);
			Instantiate(enemyPrefab[Random.Range(0, enemyPrefab.Length)], spawnPosition, Quaternion.identity);
		}
	}
}

