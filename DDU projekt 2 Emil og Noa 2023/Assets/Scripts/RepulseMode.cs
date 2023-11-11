using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepulseMode : MonoBehaviour
{

    public bool Blocking;
    float maxRepulsionDist = 2.5f;
    float repulsionForce = 4.7f;
    public Transform otherPlayer;
    public LayerMask WhatIsOtherObstacle;
    public Rigidbody2D rb;
    string[] Names = { "HostPlayer", "Player(Clone)" };
    

    // Start is called before the first frame update
    void Start()
    {
            rb = this.gameObject.GetComponent<Rigidbody2D>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("HostPlayer") !=null)
        {
            otherPlayer = GameObject.Find("Player(Clone)").transform;
        }
        else
        {
            otherPlayer = GameObject.FindObjectOfType<AudioSource>().transform;
        }

        Vector3 dir = otherPlayer.position - transform.position;
       
        float curDist = Vector3.Distance(otherPlayer.position,transform.position);
        Blocking = Physics2D.Raycast(transform.position, dir, curDist, WhatIsOtherObstacle);
        Debug.DrawRay(transform.position, dir, Color.black);

        if (!Blocking)
        {

        if ( curDist< maxRepulsionDist)
        {

        
            rb.AddForce(-dir*(repulsionForce/curDist));
              
            Debug.DrawRay(transform.position,dir,Color.green);
        }
        }
        
    }
}
