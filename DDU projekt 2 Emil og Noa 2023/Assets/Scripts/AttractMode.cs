using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractMode : MonoBehaviour
{
    bool nothingBlocking;
    float maxRepulsionDist = 8f;
    float repulsionForce = 12.3f;
    public Transform otherPlayer;
    public LayerMask WhatIsOtherPlayer;
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float curDist = Vector3.Distance(otherPlayer.position, transform.position);
        if (curDist < maxRepulsionDist)
        {

            Vector3 dir = otherPlayer.position - transform.position;

            rb.AddForce(dir * (repulsionForce / curDist));
            Debug.DrawRay(transform.position, dir, Color.green);
        }

    }
}
