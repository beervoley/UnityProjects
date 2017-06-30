using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

	public float maxYpos;
	public float spawnTime;
	public GameObject pipe;

	// Use this for initialization
	void Start () {
		StartSpawningPipes ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void StartSpawningPipes() {
		InvokeRepeating ("SpawnPipe", 1f, 1.5f);

	}

	void StopSpawningPipes() {
		CancelInvoke ("SpawnPipe");

	}

	void SpawnPipe() {
		Vector3 position = new Vector3 (transform.position.x, Random.Range(-maxYpos, maxYpos), 0);
		Instantiate (pipe, position, Quaternion.identity);
	}
}
