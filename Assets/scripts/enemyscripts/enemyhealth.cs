using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class enemyhealth : MonoBehaviour
{
   public float startingHealth;
   public float currentHealth;
   private SpriteRenderer spriteRender;
   private Animator anim;
   private bool isDead = false;

   private void Awake()
   {
	   currentHealth = startingHealth;
	   spriteRender = GetComponent<SpriteRenderer>();
   }
   public void TakeDamage(float damage)
   {
	   currentHealth -= damage;

	   if (spriteRender != null)
	   {
		   StartCoroutine(FlashRed());
	   }

	   if(currentHealth <= 0 && !isDead)
	   {
		   isDead = true;
		   Die();
	   }
	   IEnumerator FlashRed()
	   {
			spriteRender.color = Color.red;
			yield return new WaitForSeconds(0.1f);
			spriteRender.color = Color.white;
	   }

	   
   }
   private void Die()
   {
	   Debug.Log("DEATHHHH");
	   Destroy(gameObject);
   }
}
