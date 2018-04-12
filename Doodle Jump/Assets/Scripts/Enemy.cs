using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public EnemyGenerator generator;

	public void SetGenerator(EnemyGenerator eg)
	{
		generator = eg;
	}
	public void OnBecameInvisible() {
		if(generator != null)
			generator.MoveEnemy(transform);
	
	} 
}
