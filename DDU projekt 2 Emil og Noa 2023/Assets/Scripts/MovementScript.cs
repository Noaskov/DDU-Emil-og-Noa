using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class MovementScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    public float maxSpeed = 3f;
    public bool isgrounded;
    public float playerHeight;
    public LayerMask WhatIsGround;
    public bool canJump;
    public float JumpForce;

    PhotonView view;
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {

        isgrounded = Physics2D.Raycast(transform.position, Vector2.down, playerHeight * 0.5f + 0.3f, WhatIsGround);
            //  rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed);
            /*
            if(rb.velocity.x > maxSpeed)
          {
              rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
          } else if (rb.velocity.x < -maxSpeed)
          {
              rb.velocity = new Vector2(-maxSpeed, rb.velocity.y);
          }


          bool moveA = Input.GetKey(KeyCode.A);
          bool moveD = Input.GetKey(KeyCode.D);
          if(moveA && !moveD)
          {

              rb.AddForce(new Vector2(-moveSpeed,0), ForceMode2D.Force);
          } else if ( moveD && !moveA)
          {

              rb.AddForce(new Vector2(moveSpeed, 0), ForceMode2D.Force);
          }
            */

            Vector3 input = new Vector3( Input.GetAxisRaw("Horizontal"), 0, 0);
            transform.position += input.normalized * moveSpeed * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.W) && isgrounded && canJump)
        {
            canJump = false;
            rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            Invoke(nameof(ResetJump), 0.3f);
             
        }
        

        }
    }

    void ResetJump()
    {
        canJump = true;
    }
}
