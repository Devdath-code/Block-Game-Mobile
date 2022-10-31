using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewardForce = 500f;
    void FixedUpdate()
    {
         rb.AddForce(0,0,forwardForce* Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewardForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewardForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if(rb.position.y<-1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
