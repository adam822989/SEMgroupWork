using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(1, 0, 0), ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
