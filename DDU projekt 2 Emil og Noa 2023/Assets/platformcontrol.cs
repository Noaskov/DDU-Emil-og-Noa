using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformcontrol : MonoBehaviour
{
    public Transform start, slut;
    Vector3 target, dir;
    void Start()
    {
        transform.position = start.position;
        target = slut.position;
    }

    
    void FixedUpdate()
    {
        dir = target - transform.position;
        if(true){
            Debug.Log(" ");
            
        } 
        
    }
}
