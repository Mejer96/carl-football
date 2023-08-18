using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickBall : MonoBehaviour
{
    public GameObject Ball;
    public float kickForce;
    public float maxDistance;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (getDistanceToBall() && Input.GetKey("e"))
        {
            Rigidbody rigidBody = Ball.GetComponent<Rigidbody>();
            rigidBody.AddForce(kickForce, 0, 0);
        }
    }

    public bool getDistanceToBall()
    {
        float distance = Vector3.Distance(gameObject.transform.position, Ball.transform.position);

        if (distance < maxDistance)
        {
            return true;
        } else
        {
            return false;
        }

 
    }
}
