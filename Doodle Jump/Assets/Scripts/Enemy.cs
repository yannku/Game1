using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public EnemyGenerator generator;
	//setting the generator
	public void SetGenerator(EnemyGenerator eg)
	{
		generator = eg;
	}
	//when enemy is not seen any more the enemy is moved 
	public void OnBecameInvisible() {
		if(generator != null)
			generator.MoveEnemy(transform);
	
	} 
}
