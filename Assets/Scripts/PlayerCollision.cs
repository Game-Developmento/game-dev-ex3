using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo) 
    { // this code will be called if the object has a Rigidbody and Collider components
        if(collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false;
        }
    }
}
