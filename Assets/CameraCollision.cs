using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollision : MonoBehaviour
{
    public Mover playerMovement;
    Renderer rend;
    GameObject obj;

    void OnCollisionEnter(Collision collisionInfo) 
    { // this code will be called if the object has a Rigidbody and Collider components
        if(collisionInfo.collider.tag == "Coin") {
            obj = collisionInfo.gameObject;
            rend = obj.GetComponent<Renderer>();
            rend.enabled = false;
        } else if(collisionInfo.collider.tag == "Obstacle") {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false; // https://gamedevbeginner.com/how-to-quit-the-game-in-unity/
        }
    }
}
