using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class QuitGame : MonoBehaviour
{
    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("GameQUIT");
    }
}
