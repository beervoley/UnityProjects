﻿using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {



	[SerializeField]
	private float speed;

	bool started = false;
	public bool gameOver = false;

	Rigidbody rb;


	void awake() {
		rb = GetComponent<Rigidbody> ();
	}

	// Use this for initialization
	void Start () {
		awake ();
	}
	
	// Update is called once per frame
	void Update () {

		if (!started) {

			if (Input.GetMouseButtonDown (0)) {
				rb.velocity = new Vector3 (speed, 0, 0);
				started = true;
				GameManager.instance.StartGame ();
				return;
			}
		}

		if (!Physics.Raycast (transform.position, Vector3.down, 1f)) {
			gameOver = true;
			rb.velocity = new Vector3 (0, -25f, 0);

			Camera.main.GetComponent<CameraFollow>().gameOver = true;
			GameManager.instance.GameOver ();

		}

		if (Input.GetMouseButtonDown (0) && !gameOver) {
			switchDirection ();
		}
	}


	void switchDirection() {

		if (rb.velocity.z > 0) {
			rb.velocity = new Vector3 (speed, 0, 0);
		} else if (rb.velocity.x > 0) {
			rb.velocity = new Vector3 (0, 0, speed);
		}

	}
}
