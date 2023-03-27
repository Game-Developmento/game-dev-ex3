using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    
    [SerializeField] Vector3 movement = new Vector3(0,0,1); // The movement vector that determines the direction and magnitude of movement
    float movementFactor; // A scalar value between 0 and 1 that determines the position along the movement vector

    [SerializeField] float period = 4f; // The time in seconds it takes to complete one full oscillation cycle
    Vector3 startPos; // The starting position of the object

    // Start is called before the first frame update
    void Start()
    {
        // We want the object to move relative to its starting position
        startPos = transform.position; // Store the starting position of the object
    }

    // Update is called once per frame
    void Update()
    {
        if (period <= 0f) { return; } // Exit early if the period is invalid

        // Calculate the number of cycles completed since the game started
        float cycles = Time.time / period;

        const float tau = Mathf.PI * 2; // Tau (τ) is equal to 2π radians
        float rawSineWave = Mathf.Sin(cycles * tau); // Calculate the raw sine wave value based on the number of cycles completed

        movementFactor = (rawSineWave / 2f) + 0.5f; // Convert the raw sine wave value to a scalar value between 0 and 1

        Vector3 offset = movement * movementFactor; // Calculate the offset to apply to the starting position
        transform.position = startPos + offset; // Move the object to its new position
    }
}
