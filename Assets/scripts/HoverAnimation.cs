using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverAnimation : MonoBehaviour
{
    public float amplitude = 0.5f;
    public float frequency = 1f;

    Vector3 Offset = new Vector3();
    Vector3 tempOffset = new Vector3();

    private void Start()
    {
        Offset = transform.position;
    }
    private void Update()
    {
        tempOffset = Offset;
        tempOffset.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency)*amplitude;
        transform.position = tempOffset;
    }
}
