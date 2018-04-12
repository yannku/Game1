using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

	public GameObject[] enemyPrefab;
	//no. of platforms that needs to be stored
	public int numberOfenemies = 5;
	//stores width of the level
	public float levelWidth = 2f;
	public float minY = 1f;
	public float maxY = 2.5f;
	float currentTop;
	

	// Use this for initialization
	void Start () {
		
		Vector3 spawnPosition = new Vector3();
		for (int i = 0; i < numberOfenemies; i++)
		{
			spawnPosition.y += Random.Range(minY, maxY);
			spawnPosition.x = Random.Range(-levelWidth, levelWidth);
			GameObject enemy =Instantiate(enemyPrefab[Random.Range(0, enemyPrefab.Length)], spawnPosition, Quaternion.identity);

			Enemy ps =enemy.GetComponent <Enemy> ();
			if(ps != null)
				ps.SetGenerator(this);
		}
		currentTop= spawnPosition.y;
		Debug.Log (currentTop);
	}

	public void MoveEnemy(Transform enemy)
	{
		currentTop += Random.Range(minY, maxY);
		Debug.Log (currentTop);
		Vector3 pos =enemy.position;

		pos.y = currentTop;
		pos.x = Random.Range(-levelWidth, levelWidth);

		enemy.position = pos;
	}
}

