using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;

	private Rigidbody rigidbody = null;
	// Use this for initialization
	void Start () {
		rigidbody = gameObject.GetComponent(typeof(Rigidbody)) as Rigidbody;
		rigidbody.AddForce(0,200,500);
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		rigidbody.AddForce(0,0,forwardForce* Time.deltaTime);
		if(Input.GetKey("d")) {
			rigidbody.AddForce(sidewaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		if(Input.GetKey("a")) {
			rigidbody.AddForce(-sidewaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		if(rigidbody.position.y < -1f) {
			FindObjectOfType<GameManager>().gameOver();
		}
	}
}
