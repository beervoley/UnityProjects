using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	public static ScoreManager instance;

	int score;
	public bool gameOver;

	string highScoreKey = "highScore";
	string currentScoreKey = "currentScore";



	void Awake() {
		if (instance == null) {
			instance = this;
		}
	}


	// Use this for initialization
	void Start () {
		score = 0;
		PlayerPrefs.SetInt (currentScoreKey, 0);
		gameOver = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void IncrementScore() {
		if (!gameOver) {
			score++;
		}
	}

	public void StopScore() {
		gameOver = true;
		PlayerPrefs.SetInt (currentScoreKey, score);
		if (PlayerPrefs.HasKey (highScoreKey)) {
			if (score > PlayerPrefs.GetInt (highScoreKey)) {
				PlayerPrefs.SetInt (highScoreKey, score);
			}
		} else {
			PlayerPrefs.SetInt (highScoreKey, score);
		}
	}
}
