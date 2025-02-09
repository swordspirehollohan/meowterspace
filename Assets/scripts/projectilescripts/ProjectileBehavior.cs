using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float Speed = 4f;
    public float destroyacid = 5f;

    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * Speed;
        Destroy(gameObject, destroyacid);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    
}
