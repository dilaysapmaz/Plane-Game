using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float SideForce = 50f;

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")){
            rb.AddForce(SideForce, 0, 0,ForceMode.VelocityChange);   
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideForce, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, SideForce, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, -SideForce, 0, ForceMode.VelocityChange);
        }
    }
}
