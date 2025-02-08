using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GuppyCollect : MonoBehaviour
{
    public int Count = 0;
    public TMP_Text guppyText;

    void Update()
    {
        guppyText.text = ": " + Count;
    }

}
