using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EELPLANT : MonoBehaviour
{
    public float waitTime = 2f; 
    private Animator animator;
    private bool canDamage = false;
    private bool isWaiting = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        canDamage = false;  
        StartCoroutine(EELCycle());
    }

    private IEnumerator EELCycle()
    {
        while (true)
        {
            if (!isWaiting)
            {
                animator.Play("eel_animation");
                canDamage = true; 

                isWaiting = true;
                yield return new WaitForSeconds(waitTime);

                animator.Play("Idle");
                canDamage = false; 

                yield return new WaitForSeconds(waitTime);
                isWaiting = false;
            }
            yield return null;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (canDamage && other.CompareTag("Player"))
        {
            health playerHealth = other.GetComponent<health>();
            if (playerHealth != null)
            {
                Debug.Log("Player hit by EELPLANT!");
                playerHealth.TakeDamage(3);
            }
        }
    }
}