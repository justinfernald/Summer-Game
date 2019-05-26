using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocitySetter : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddRelativeForce(velocity);
    }
}
