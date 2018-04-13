using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {
	//reference to the platform
	public GameObject[] platformPrefab;
	//no. of platforms that needs to be stored
	public int numberOfPlatforms = 20;
	//stores width of the level
	public static float levelWidth = 2.3f;
	//min and max for the position of the enemies
	public float minY = 1f;
	public float maxY = 2.5f;
	//last platform on top
	float currentTop;

	// Use this for initialization
	//spawning platforms according to level width and max and min y (allways at random)
	void Start () {
		Vector3 spawnPosition = new Vector3();
		for (int i = 0; i < numberOfPlatforms; i++)
		{
			
			spawnPosition.y += Random.Range(minY, maxY);
			spawnPosition.x = Random.Range(-levelWidth, levelWidth);
			GameObject platform = Instantiate(platformPrefab[Random.Range(0, platformPrefab.Length)], spawnPosition, Quaternion.identity);

			Platform ps =platform.GetComponent <Platform> ();
			if(ps != null)
				ps.SetGenerator(this);

		}
		currentTop= spawnPosition.y;
		Debug.Log (currentTop);
	}
	
	//moving the last platfrom at the top
	public void MovePlatform(Transform platform)
	{
		currentTop += Random.Range(minY, maxY);
		Debug.Log (currentTop);
		Vector3 pos =platform.position;

		pos.y = currentTop;
		pos.x = Random.Range(-levelWidth, levelWidth);

		platform.position = pos;
	}
}
