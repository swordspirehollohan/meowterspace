using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollectSystem : MonoBehaviour
{
    public GuppyCollect gubbyCollect;

    public AudioSource deathSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("collectable"))
        {
            Destroy(other.gameObject);
            gubbyCollect.Count ++;

            deathSound.Play();
        }
    }

}
