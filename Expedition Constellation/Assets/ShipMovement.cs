using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour {

	public float speed;

	public float thrustFactor;

	private float accel = 1f;

	public float turnSpeed;

	public float rollSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*if(Input.GetKey(KeyCode.W)) {
			accel += 0.001f;
			rigidbody.AddForce(transform.forward * speed * thrustFactor * accel, ForceMode.Acceleration);
		} else {
			accel = 1f;
		}
		if(Input.GetKey(KeyCode.S)) {
			rigidbody.AddForce(-transform.forward * speed * thrustFactor * accel, ForceMode.Acceleration);
		}

		if(Input.GetKey(KeyCode.D)) {
			rigidbody.AddRelativeTorque(0,0,-speed/rollSpeed, ForceMode.Acceleration);
		}

		if(Input.GetKey(KeyCode.A)) {
			rigidbody.AddRelativeTorque(0,0,speed/rollSpeed, ForceMode.Acceleration);
		}

		if(Input.GetKey(KeyCode.UpArrow)) {
			rigidbody.AddRelativeTorque(-speed/turnSpeed,0,0, ForceMode.Acceleration);
		}

		if(Input.GetKey(KeyCode.DownArrow)) {
			rigidbody.AddRelativeTorque(speed/turnSpeed,0,0, ForceMode.Acceleration);
		}

		if(Input.GetKey(KeyCode.LeftArrow)) {
			rigidbody.AddRelativeTorque(0,-speed/turnSpeed,0, ForceMode.Acceleration);
		}
		
		if(Input.GetKey(KeyCode.RightArrow)) {
			rigidbody.AddRelativeTorque(0,speed/turnSpeed,0, ForceMode.Acceleration);
		}*/


	}
}
