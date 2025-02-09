using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class enemyhealth : MonoBehaviour
{
   public float startingHealth;
   public float currentHealth;

   private Animator anim;
   private bool isDead = false;


   private void Awake()
   {
	   currentHealth = startingHealth;
   }
   public void TakeDamage(float damage)
   {
	   currentHealth -= damage;

	   if(currentHealth <= 0 && !isDead)
	   {
		   isDead = true;
		   Die();
		 }
	   
   }
   private void Die()
   {
	   Debug.Log("DEATHHHH");
	   Destroy(gameObject);
   }
}
