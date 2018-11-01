using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
		rigidbody = gameObject.GetComponent(typeof(Rigidbody)) as Rigidbody;
		rigidbody.AddForce(0,200,500);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
