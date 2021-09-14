using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceL : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.left * force);
    }

    void Update()
    {
        
    }
}
