using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class QuitGame : MonoBehaviour
{
    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("GameQUIT");
    }
}
