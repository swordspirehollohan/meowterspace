using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyshooting : MonoBehaviour
{
	public GameObject bubblebullet;
	public Transform bulletpos;
	public float disenemy = 4f;

	private GameObject player;
	private float timer;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}
	void Update()
	{

		float distance = Vector2.Distance(transform.position, player.transform.position);
		//ebug.Log(distance);

		if(distance < disenemy)
		{
			timer += Time.deltaTime;
			if(timer > 2)
			{
				timer = 0;
				shoot();
			}

		}
	
	}

	void shoot()
	{
		Instantiate(bubblebullet, bulletpos.position, Quaternion.identity);
	}
}
