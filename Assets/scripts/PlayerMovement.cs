using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 3f;
	public float jumpforce = 3f;
	private Rigidbody2D body;

	private bool isJumping;

	private void Awake()
	{
		body = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

		if(Input.GetKeyDown(KeyCode.Space) && isJumping == false)
		{
			body.velocity = new Vector2(body.velocity.x, jumpforce);
		}
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.CompareTag("Floor"))
		{
			isJumping = false; 
		}
	}

	private void OnCollisionExit2D(Collision2D other)
	{
		if(other.gameObject.CompareTag("Floor"))
		{
			isJumping = true;
		}
	}

}
