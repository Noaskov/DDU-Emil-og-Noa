using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    private float Threshold = 0.1f;
    private float Speed = 2f;
    public Transform[] Waypoints;
    int target;
    
   
    void Start()
    {

        transform.position = Waypoints[0].position;
    }

    
   public  void Activated(int Index)
    {
        target = Index;
        
    }

    public void Unactivated(int Index)
    {
        target = Index;
        
    }

    private void Update()
    {
        if (Vector2.Distance(Waypoints[target].position, transform.position) > Threshold)
        {
            transform.position = Vector2.MoveTowards(transform.position, Waypoints[target].position, Time.deltaTime * Speed);
        }
    }


}
