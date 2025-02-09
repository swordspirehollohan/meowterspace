using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
	[SerializeField] private health playerHealth;
	[SerializeField] private Image totalhealthbar;
	[SerializeField] private Image currenthealthbar;

	private void Start()
	{
		totalhealthbar.fillAmount = playerHealth.currentHealth /3;
	}
	private void Update(){
		currenthealthbar.fillAmount = playerHealth.currentHealth / 3;
	}
}
