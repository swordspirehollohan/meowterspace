using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float Speed = 4f;
    public float destroyacid = 5f;
    public float damageamount = 1f;

    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * Speed;
        Destroy(gameObject, destroyacid);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemyhealth enemy = collision.GetComponent<enemyhealth>();

        if (enemy != null)
        {
            enemy.TakeDamage(damageamount);
            Destroy(gameObject);
            Debug.Log("enemyOUC");
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
}
