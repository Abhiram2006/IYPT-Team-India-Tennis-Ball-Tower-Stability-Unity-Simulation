using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WIndSim : MonoBehaviour
{
	public float strength;
	public Vector3  direction;
Rigidbody rb;	
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(direction * strength);
    }
}
