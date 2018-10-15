using UnityEngine;
using System.Collections;

public class enemyCarMove : MonoBehaviour {

	// Use this for initialization
	public float speed = 8f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (0, 1, 0) * speed * Time.deltaTime);
	}
}
