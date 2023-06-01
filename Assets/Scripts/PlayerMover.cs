using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    Rigidbody rb; 
    public float speed; 
    public float jumpForce; 
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical"); 

        rb.AddRelativeForce(horizontal, 0f, vertical, ); 

        if(Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce (Vector3.up * jumpForce); 
        }

    }
}
