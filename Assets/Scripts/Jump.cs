using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float JumpForce;
    public Rigidbody reggiebody;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Vector3 forceVector = Vector3.up * JumpForce;
            reggiebody.AddForce(forceVector); 

            print("Down");
        }
        else if (Input.GetButton("Jump"))
        {
            print("Hold");
         }
        else if (Input.GetButtonUp("Jump"))
        {
            print("Up");
        }

    }
}