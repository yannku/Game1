using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {

	public float movementSpeed = 10f;
	public bool canControl = true;
	
	Rigidbody2D rb;
	public float movement = 0f;
	
	// Use this for initialization
	void Start () {
		rb= GetComponent<Rigidbody2D>();
		Time.timeScale = 1;
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

	void OnCollisionEnter2D(Collision2D coll) {
		if(coll.collider.tag == "enemy")
		{
			Time.timeScale = 0;
			//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}

	void OnBecameInvisible()
	{
		Time.timeScale = 0;
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

}
