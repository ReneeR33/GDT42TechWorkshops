using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float sidewaysForce = 500f;
	public float forwardForce = 2000f;

	private Rigidbody rb;

	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate()
	{
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);
		if (Input.GetKey("d")) rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		if (Input.GetKey("a")) rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
