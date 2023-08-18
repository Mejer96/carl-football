using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKeeperMovement : MonoBehaviour
{
    public Rigidbody rigidbody;
    bool moveLeft = false;
    bool moveRight = true;
    public float force;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameObject.transform.position.z < -3.66)
        {
            moveLeft = true;
            moveRight = false;
        }

        if (gameObject.transform.position.z > 3.66f)
        {
            moveLeft = false;
            moveRight = true;
        }

        if (moveLeft)
        {
            transform.Translate(0, 0, force);
        }

        if (moveRight)
        {
            transform.Translate(0, 0, -force);
        }
        
    }
}
