using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (Vector3.down * Time.deltaTime * 10f);
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			if (PlayerPrefs.GetInt ("Highscore") <= ScoreController.instance.score) {
				PlayerPrefs.SetInt ("Highscore", ScoreController.instance.score);
			}
			Destroy (other.gameObject);
			SceneManager.LoadScene ("StartMenu");
		}
	}
}
