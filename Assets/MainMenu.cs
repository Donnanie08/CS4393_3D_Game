﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public Canvas exitMenu;
	public Button playText; //for PLAY button
	public Button exitText; //for EXIT button
	
	// Use this for initialization
	void Start () {
		//grap the Button and Canvas type and attach to them
		exitMenu = exitMenu.GetComponent<Canvas>();
		playText = playText.GetComponent<Button>();
		exitText = exitText.GetComponent<Button>();
		exitMenu.enabled = false;
	}

	//call this function whenever the user click on "EXIT" button
	public void ExitPress(){
		exitMenu.enabled = true; //will display the exit menu canvas
		//disable PLAY and EXIT buttons
		playText.enabled = false; 
		exitText.enabled = false;
	}

	//call this function whenever the user click on "NO" button
	public void NoPress (){
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
}
