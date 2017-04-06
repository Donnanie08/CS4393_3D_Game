using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour {
	//public Transform canvas;
	public Transform Player;
	public GameObject pauseButton, pauseMenu;
	public static bool isPaused;


	void Start()
	{
		OnUnPause ();
		isPaused = false;
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape) || Input.GetKeyDown (KeyCode.P)) {
			OnPause ();
		}
	}


	public void OnPause(){
		pauseButton.SetActive (false);
		pauseMenu.SetActive (true);
		Time.timeScale = 0;
		isPaused = true;
	}

	public void OnUnPause(){
		pauseButton.SetActive (true);
		pauseMenu.SetActive (false);
		Time.timeScale = 1;
		isPaused = false;
	}
	/*
	public void Pause(){
		if (canvas.gameObject.activeInHierarchy == false) {
			canvas.gameObject.SetActive (true);
			// makes envrionemnt not moving 
			Time.timeScale = 0;
			Player.GetComponent<FirstPersonController> ().enabled = false;
		} else {
			canvas.gameObject.SetActive (false);
			Time.timeScale = 1;
			Player.GetComponent<FirstPersonController> ().enabled = true;
		}

	}
*/
	public void Retry(){
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (currentIndex);
	}

	public void MainMenu(){
		//int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(0);
	}
}
