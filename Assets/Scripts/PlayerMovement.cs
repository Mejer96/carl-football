using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float playerVelocity = 200f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate() 
    {
        if (Input.GetKey("w")) 
        {
            rigidBody.AddForce(0, 0, playerVelocity);
        }

         if (Input.GetKey("s")) 
        {
            rigidBody.AddForce(0, 0, -playerVelocity);
        }

         if (Input.GetKey("a")) 
        {
            rigidBody.AddForce(-playerVelocity, 0, 0);
        }

         if (Input.GetKey("d")) 
        {
            rigidBody.AddForce(playerVelocity, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
