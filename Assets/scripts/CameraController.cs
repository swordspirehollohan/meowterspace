using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 2f;
    private float yoffset = 2f;
    public Transform target;


    void Update(){

        Vector3 newPos = new Vector3(target.position.x, target.position.y + yoffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, speed*Time.deltaTime);
    
    }
    
}
