using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public Player player;

	void OnCollisionEnter2D(Collision2D coll) {
		if(coll.collider.tag == "enemy")
		{
			player.movement = 0f;
		}
	}
}
