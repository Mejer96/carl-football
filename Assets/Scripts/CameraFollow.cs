using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerPosition;
    public Vector3 cameraPositionRelativeToPlayer;
    // Update is called once per frame
    void Update()
    {
        transform.position = playerPosition.position + cameraPositionRelativeToPlayer;
    }
}
