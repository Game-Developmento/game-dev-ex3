using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 100f;

    // Update is called once per frame
    void FixedUpdate() // use FixedUpdate when using physics (adding forces / changing velocity) - will look smoother
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Time.deltaTime = amount of seconds since the computer drew the last frame (even out frame rate)

        if(Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // velocity ignores the object mass
        }

        if(Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}
