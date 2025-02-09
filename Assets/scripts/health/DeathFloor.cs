using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathFloor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")){
            Debug.Log("DEATHHHHHHH");
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}
