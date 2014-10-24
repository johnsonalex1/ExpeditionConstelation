using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Thruster : MonoBehaviour {

	public KeyCode activateKey;//This key will activate these thrusters, for now, thrusters are toggled, but analog versions will be created later

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(activateKey)) {
			rigidbody.AddRelativeForce(0.0f,0.0f,1.0f);
		}
	}
}
