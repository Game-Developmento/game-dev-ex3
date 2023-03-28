using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// useful source: https://youtu.be/fwSWZ-DNm7Y

public class Oscillator : MonoBehaviour
{
    
    [SerializeField] Vector3 movement; // movement vector - determines the direction and magnitude of movement
    float movementFactor; // value between 0 and 1 - determines the position along the movement vector

    [SerializeField] float period; // time (in seconds) to complete one oscillation cycle
    Vector3 startPos; // store position - we want the object to move relative to its starting position
    
    void Start()
    {
        switch(this.name) {
            case "Sphere":
                movement = new Vector3(2, 0, 0);
                period = 1f;
                break;
            case "Cube":
                movement = new Vector3(0, 1, 2);
                period = 5f;
                break;
            case "Cylinder":
                movement = new Vector3(0, 0, 3);
                period = 10f;
                break;
            default:
                movement = new Vector3(0, 2, 1);
                period = 4f;
                break;
        }
        startPos = transform.position;
    }

    void Update()
    {
        if (period <= 0f) { return; }
        
        float cycles = Time.time / period; // number of cycles completed since the game started

        const float tau = Mathf.PI * 2;
        float movementFactor = Mathf.Sin(cycles * tau); // sine wave value based on the number of cycles completed
        Vector3 offset = movement * movementFactor;
        // Debug.Log(offset);

        transform.position = startPos + offset; // move the object to its new position
    }
}
