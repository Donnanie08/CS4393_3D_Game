using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public Canvas exitMenu;
	public Button playText; //for PLAY button
	public Button exitText; //for EXIT button
	//public GameObject HowtoplayPanel;
	//public GameObject HowtoplayButton;
	//public GameObject BacktomainButton;
	
	// Use this for initialization
	void Start () {
		Cursor.visible =true;
		//grap the Button and Canvas type and attach to them
		exitMenu = exitMenu.GetComponent<Canvas>();
		playText = playText.GetComponent<Button>();
		exitText = exitText.GetComponent<Button>();
		exitMenu.enabled = false;
		//HowtoplayPanel.SetActive (false);
	}
	void Update(){
		Cursor.visible = true;
	}

	//call this function whenever the user click on "EXIT" button
	public void ExitPress(){
		exitMenu.enabled = true; //will display the exit menu canvas
		//disable PLAY and EXIT buttons
		playText.enabled = false; 
		exitText.enabled = false;
	}

	//call this function whenever the user click on "NO" button
	public void NoPress ()
	{
		exitMenu.enabled = false;
		playText.enabled = true;
		exitText.enabled = true;
	}

	//when click on "PLAY" button
	public void StartLevel (){
		SceneManager.LoadScene("Level1Scene");
	}

	//quit the entire game
	public void ExitGame(){
		Application.Quit();
	}

	/*
	public void HowToPlay(){
		HowtoplayPanel.SetActive (true);
		exitMenu.enabled = false; //will display the exit menu canvas
		//disable PLAY and EXIT buttons
		playText.enabled = false; 
		exitText.enabled = false;
		HowtoplayButton.SetActive (false);
	}

	public void BacktoMainMenu(){
		HowtoplayPanel.SetActive (true);
	}
	*/
}