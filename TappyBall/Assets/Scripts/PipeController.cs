using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour {

	public float horizontalSpeed;
	public float verticalSpeed;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		MovePipe ();
		//InvokeRepeating ("SwitchUpDown", 0.1f, 1f);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "PipeRemover") {
			Destroy (gameObject);
		}
	}


	void MovePipe () {
		rb.velocity = new Vector2 (-horizontalSpeed, 0);
	}


	void SwitchUpDown() {
		verticalSpeed = -verticalSpeed;
		rb.velocity = new Vector2 (-horizontalSpeed, verticalSpeed);
	}
	void MoveVertically () {
		rb.velocity = new Vector2 (0, verticalSpeed);
	}
}
