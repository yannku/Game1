using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {

	public float movementSpeed = 10f;
	public bool canControl = true;
	
	Rigidbody2D rb;
	float movement = 0f;
	
	// Use this for initialization
	void Start () {
		rb= GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!canControl) return;

		movement = Input.GetAxis("Horizontal") * movementSpeed;
		
		Vector3 pos = transform.position;

		if (pos.x > 2.7f)  {
			pos.x = -2.7f;
		}
		else if (pos.x <-2.7f) {
			pos.x = 2.7f;
		}
		transform.position = pos;
		
	}

	void FixedUpdate()
	{
		Vector2 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;
	}
}
