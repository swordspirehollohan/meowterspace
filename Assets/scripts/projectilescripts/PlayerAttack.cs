using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    
    public ProjectileBehavior ProjectilePrefab;
    public Transform LaunchOffset;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Quaternion projectileRotation = LaunchOffset.rotation;

            if(transform.localScale.x <0){
                projectileRotation *= Quaternion.Euler(0,0,180);
            }
            Instantiate(ProjectilePrefab, LaunchOffset.position, projectileRotation);
        }
    }
}
