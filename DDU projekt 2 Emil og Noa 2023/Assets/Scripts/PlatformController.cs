using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    private float Threshold = 0.1f;
    private float Speed = 0.03f;
    public Transform StartPosition;
    public Transform EndPosition;
    Transform target;
    Vector3 dir;
   
    void Start()
    {
        
        transform.position = StartPosition.position;
        target.position = StartPosition.position;
        
    }

    
    void FixedUpdate()
    {
        dir = transform.position - target.position;
        dir = dir.normalized * Speed;
        if(dir.sqrMagnitude < Threshold)
        {
            target.position = EndPosition.position;
        }
        
        
        transform.position -= dir;
    }

    
}
