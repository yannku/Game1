using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

	public LevelGenerator generator;

	public float jumpForce = 10f;

	public void SetGenerator(LevelGenerator lg)
	{
		generator = lg;
	}
	//settind the jump force for when player hits the platform
	void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.relativeVelocity.y <= 0f) 
		{
			Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
			if(rb != null)
			{
				Vector2 velocity = rb.velocity;
				velocity.y = jumpForce;
				rb.velocity = velocity;
			}
		}	
	}
	//moving platforms on top 
	public void OnBecameInvisible() {
		if(generator != null)
			generator.MovePlatform(transform);
	
	} 
}
