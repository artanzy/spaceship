using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<Text> ().text = "HighScore : " + PlayerPrefs.GetInt ("Highscore").ToString ();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
