using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	public static ScoreController instance;

	// Use this for initialization
	void Awake() { 
		instance = this;
	}

	public int score=0;
	public Text ScoreBoard;

	void Start () {
		
	}
	
	// Update is called once per frame
	public void UpdateScore() {
		score += 1;
		ScoreBoard.text = "Score : " + score.ToString ();
	}

	//void Update () {
		
	//}
}
