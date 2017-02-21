using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyController : MonoBehaviour {

	public GameObject myEnemy;
	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnEnemies (1f));
	}
	
	// Update is called once per frame
	void Update () {
		//Instantiate (myEnemy, this.gameObject.transform.position, Quaternion.identity);
	}

	IEnumerator SpawnEnemies(float waitTime) {
		yield return new WaitForSeconds (waitTime);
		while (true) {
			Vector3 originalPosition = myEnemy.gameObject.transform.position;
			for (int i = 0; i < 3; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range (-originalPosition.x - 5, originalPosition.x + 5), originalPosition.y, originalPosition.z);
				Instantiate (myEnemy, spawnPosition, Quaternion.identity);
				yield return new WaitForSeconds (waitTime / 5);
			}
			yield return new WaitForSeconds (waitTime);
		}
	}
}
