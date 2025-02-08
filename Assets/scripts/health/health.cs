using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class health : MonoBehaviour
{
   [SerializeField] private float startingHealth;
   public float currentHealth {get; private set;}


   private void Awake()
   {
	   currentHealth = startingHealth;
   }
   public void TakeDamage(float _damage)
   {
	   currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
	   if(currentHealth > 0)
	   {
		   //playerhurt
	   }
	   else{
		   //playerdead
	   }
   }

   
}
