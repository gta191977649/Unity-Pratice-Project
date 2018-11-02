using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollison : MonoBehaviour {

	public PlayerController playerController;

	private void OnCollisionEnter(Collision collisonInfo) {
		if(collisonInfo.collider.tag == "Obstacle") {
			playerController.enabled = false;
			FindObjectOfType<GameManager>().gameOver();
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
