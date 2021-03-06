using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class carController : MonoBehaviour {

	// Use this for initialization

	public float carSpeed;
	public AudioManager am;
	//Vector3 position;
	Vector3 position;
	public uiManager ui;
	void Start () {
		
		position = transform.position;
	}
	public void awake(){
		am.carSound.Play ();
	}
	// Update is called once per frame
	void Update () {
		position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;
		position.x = Mathf.Clamp(position.x, -2.0f, 2.0f);
		transform.position = position;
		/*if (Input.touchCount == 1) {

			Touch touch = Input.touches[0];
			if(touch.position.x < Screen.width/2){
				transform.position += Vector3.left * carSpeed * Time.deltaTime;


			}
			else if(touch.position.x > Screen.width/2){
				transform.position += Vector3.right * carSpeed * Time.deltaTime;

			}
			position = transform.position;
			position.x = Mathf.Clamp(position.x, -2.0f, 2.0f);
			transform.position = position;

		}*/
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy Car") {
			Destroy (gameObject);
			ui.GameOver ();
			am.carSound.Stop ();

		}
	}
}
