using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // Declaring the RigidBody variable 'rb'
    public Rigidbody rb;

    // Variable for amount of forward force
    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;


    // Using FixedUpdate() because we are using physics
    void FixedUpdate()
    {
        // Add forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);


        // Check if user is pressing the "right" key
        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Check if user is pressing the "left" key
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
