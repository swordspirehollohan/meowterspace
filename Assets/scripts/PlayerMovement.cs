using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private bool isfacingRight = true;
	public float speed = 3f;
	private Rigidbody2D body;

	public float jumpforce = 3f;
	private bool isJumping;


	private Animator anim;


	private void Awake()
	{
		anim = GetComponent<Animator>();
		body = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		float xaxis = Input.GetAxis("Horizontal");

		body.velocity = new Vector2(xaxis * speed, body.velocity.y);

		if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
		{
			body.velocity = new Vector2(body.velocity.x, jumpforce);
			anim.SetBool("isJumping", true);
		}

		if(anim != null)
		{
			if(body.velocity != Vector2.zero)
			{
				anim.SetBool("isRunning", true);
			}
			else
			{
				anim.SetBool("isRunning", false);
			}
		}
		if(!isfacingRight && xaxis >0)
		{
			Flip();
		}
		else if(isfacingRight && xaxis <0)
		{
			Flip();
		}

	}
	

	private void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.CompareTag("Floor"))
		{
			isJumping = false; 
			anim.SetBool("isJumping", false);
		}
	}

	private void OnCollisionExit2D(Collision2D other)
	{
		if(other.gameObject.CompareTag("Floor"))
		{
			isJumping = true;
		}
	}

	public void Flip()
	{
		isfacingRight = !isfacingRight;
		Vector3 localScale = transform.localScale;
		localScale.x *= -1f;
		transform.localScale = localScale;
	}

}
