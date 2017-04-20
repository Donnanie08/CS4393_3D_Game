using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class aimWindowAction : MonoBehaviour {
	public Image AimWindow;
	//private bool calledFunc;

	// Use this for initialization
	void Start () {
		AimWindow.enabled = true;
		//calledFunc = PauseGame.didFunction;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape) || Input.GetKeyDown (KeyCode.P)) {
			AimWindow.enabled = false;
		}
		//calledFunc = PauseGame.didFunction;
//		if (calledFunc) {
//			AimWindow.enabled = true;
//		}
	}

	public void DisplayAimWindow ()
	{
		AimWindow.enabled = true;
	}

}
