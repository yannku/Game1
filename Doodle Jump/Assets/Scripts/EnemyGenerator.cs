using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

	public GameObject[] enemyPrefab;
	//no. of enemies that needs to be stored
	public int numberOfenemies = 5;
	//stores width of the level
	public float levelWidth = 2f;
	//min and max for the position of the enemies
	public float minY = 1f;
	public float maxY = 2.5f;
	//last enemy on top
	float currentTop;
	

	// Use this for initialization
	//spawning enemies according to level width and max and min y (allways at random)
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

	//moving last enemy at the top
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

