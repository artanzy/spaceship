using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	public AudioClip myExplosion;
	// Use this for initialization
	void Start () {
		Color bulletColor = new Color( Random.value, Random.value, Random.value, 1.0f);
		gameObject.GetComponent<Renderer> ().material.color = bulletColor;
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (Vector3.up * Time.deltaTime * 10f);
		if (this.gameObject.transform.position.y >= 20f) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter (Collider other) {
		Destroy (other.gameObject);
		this.gameObject.GetComponent<AudioSource> ().clip = myExplosion;
		this.gameObject.GetComponent<AudioSource> ().Play ();
		ScoreController.instance.UpdateScore ();
		//Destroy (this.gameObject);

	}
}
