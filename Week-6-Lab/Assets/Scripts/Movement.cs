using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up);
        }
    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeForce(Vector2.left);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeForce(Vector2.right);
        }
    }





}
