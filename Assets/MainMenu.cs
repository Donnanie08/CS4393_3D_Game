using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public GameObject exitMenu;
	public GameObject playText; //for PLAY button
	public GameObject exitText; //for EXIT button
	public GameObject HowtoplayPanel;
	public GameObject HowtoplayButton;
	public GameObject BacktomainButton;
	
	// Use this for initialization
	void Start () {
		Cursor.visible =true;
		//grap the Button and Canvas type and attach to them

		exitMenu.SetActive(false);
		Cursor.lockState = CursorLockMode.None;
		HowtoplayButton.SetActive (true);
		HowtoplayPanel.SetActive (false);
	}

	void Update(){
		Cursor.visible =true;
		Cursor.lockState = CursorLockMode.None;
		HowtoplayButton.SetActive (true);
		HowtoplayPanel.SetActive (false);

	}


	//call this function whenever the user click on "EXIT" button
	public void ExitPress(){
		exitMenu.SetActive(true); //will display the exit menu canvas
		//disable PLAY and EXIT buttons
		playText.SetActive(false); 
		exitText.SetActive (false);
		HowtoplayButton.SetActive (false);
	}

	//call this function whenever the user click on "NO" button
	public void NoPress ()
	{
		exitMenu.SetActive (false);
		playText.SetActive (true);
		exitText.SetActive (true);
		HowtoplayButton.SetActive (true);

	}

	//when click on "PLAY" button
	public void StartLevel (){
		SceneManager.LoadScene("Level1Scene");
	}

	//quit the entire game
	public void ExitGame(){
		Application.Quit();
	}


	public void HowToPlay(){
		exitMenu.SetActive (false); //will display the exit menu canvas
		//disable PLAY and EXIT buttons
		playText.SetActive (false); 
		exitText.SetActive (false);
		HowtoplayButton.SetActive (false);
		HowtoplayPanel.SetActive (true);

	}

	public void BacktoMainMenu(){
		HowtoplayPanel.SetActive (false);
		HowtoplayButton.SetActive (true);
		playText.SetActive (true);
		exitText.SetActive (true);
		Cursor.visible =true;
		Cursor.lockState = CursorLockMode.None;
	}

}