using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform objectToFollow;
    public Vector2 movementRatio = Vector2.one;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = objectToFollow.position;
        newPosition.x *= movementRatio.x;
        newPosition.y *= movementRatio.y;
        newPosition.z = transform.position.z;
        transform.position = newPosition;
    }
}