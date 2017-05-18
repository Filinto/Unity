using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelerometer : MonoBehaviour {

    private Rigidbody rigid;

	// Use this for initialization
	private void Start ()
    {
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	private void Update ()
    {
        rigid.AddForce(Input.acceleration);
	}
}
