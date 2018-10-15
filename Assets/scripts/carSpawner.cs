using UnityEngine;
using System.Collections;

public class carSpawner : MonoBehaviour {

	// Use this for initialization
	public GameObject car;
	public float maxPos = 2f;
	public float delayTimer = 0.5f;
	float timer;
	void Start () {
		timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			Vector3 carPos = new Vector3 (Random.Range (-2.0f, 2.0f), transform.position.y, transform.position.z);
			Instantiate (car, carPos, transform.rotation);
			timer = delayTimer;
		}
	}
}
