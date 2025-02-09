using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class health : MonoBehaviour
{
   public float startingHealth;
   public float currentHealth;

   private Animator anim;
   private bool isDead = false;


   private void Awake()
   {
	   currentHealth = startingHealth;
   }
   public void TakeDamage(float _damage)
   {
	   currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

	   if(currentHealth > 0)
	   {
		   Debug.Log("OUCH");
	   }
	   else if(!isDead)
	   {

			isDead = true;
			Die();
		   
	   }
   }
   public void Die()
   {
	   Debug.Log("DEATHHHH");
	   //anim.SetTrigger("Death");
	   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
}
