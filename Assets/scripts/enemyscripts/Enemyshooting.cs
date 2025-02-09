using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyshooting : MonoBehaviour
{
	public GameObject bubblebullet;
	public Transform bulletpos;

	private float timer;

	void Start()
	{

	}
	void Update()
	{
		timer += Time.deltaTime;

		if(timer > 2)
		{
			timer = 0;
			shoot();
		}
	}

	void shoot()
	{
		Instantiate(bubblebullet, bulletpos.position, Quaternion.identity);
	}
}
