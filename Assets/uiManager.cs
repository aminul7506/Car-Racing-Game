using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uiManager : MonoBehaviour {

	public Text scoreText;
	int score;
	public  bool gameOver;
	public AudioManager am;
	public  Button[] buttons;
	// Use this for initialization
	void Start () {
		gameOver = false;
		score = 0;
		InvokeRepeating ("scoreUpdate", 1.0f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score : " + score;
	}

	public void GameOver(){
		gameOver = true;
		foreach (Button but in buttons) {
			but.gameObject.SetActive(true);
		}
	}

	void scoreUpdate(){
		if(gameOver == false)score += 1;	}

	public void Play(){
		Application.LoadLevel ("level1");
		//SceneManager.LoadScene ("level1");
	}

	public void Pause(){
		if (Time.timeScale == 1) {
			Time.timeScale = 0;
			am.carSound.Stop ();
		} 
		else if (Time.timeScale == 0) {
			Time.timeScale = 1;
			am.carSound.Play ();
		}
	}

	public void Menu(){
		Application.LoadLevel ("Menu");
	}

	public void Exit(){
		Application.Quit ();
	}
}
