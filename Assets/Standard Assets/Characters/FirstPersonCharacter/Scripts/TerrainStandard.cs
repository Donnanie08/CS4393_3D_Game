using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

using UnityEngine.UI;
public class TerrainStandard : MonoBehaviour {

	public static int boxesOnGround;
	public int numberOfBoxes;
	static public Dictionary<int, int> hashMap = new Dictionary<int, int> ();
	static public int level;
	public int thisLevel;
	static public int power;
	static public int coconutNum;
	public int powerInc;
	public GameObject LostPanel;
	public GameObject WinPanel;
	private int prevScene;
	private int curScene;
	public MouseLook mouseLook;
	public bool cursorShow;
	public Transform Player;

	public bool panelactivate;

	// Use this for initialization
	void Start () {
		//print (numberOfBoxes);
		boxesOnGround = 0;
		coconutNum = 2;
		power = 500;
		powerInc = 10;
		level = thisLevel;
		WinPanel.SetActive (false);
		LostPanel.SetActive (false);
		prevScene = SceneManager.GetActiveScene().buildIndex;

		/*
		if ((TerrainBehavior.level) == 1) {
			score2beat1 =4800;
		} else if ((TerrainBehavior.level) == 2) {
			score2beat2 = 3000;
		} else if ((TerrainBehavior.level) == 3) {
			score2beat3 = 2000;
		}
		*/
	}

	// Update is called once per frame
	void Update () {
		/*
		if (boxesOnGround == numberOfBoxes * 3 / 4) {
			if (level == 1) {
				SceneManager.LoadScene ("Level2Scene");
			} else if (level == 2) {
				SceneManager.LoadScene ("Level3Scene");
			} else {
				LostPanel.SetActive (true);
				Time.timeScale = 0;
				Cursor.visible = true;
				SceneManager.LoadScene(0);
			}}
*/
		curScene = SceneManager.GetActiveScene ().buildIndex;

		if ((boxesOnGround * 200 > 2500)) {
			WinPanel.SetActive (true);
			//Cursor.visible = true;
			//Cursor.lockState = CursorLockMode.None;
			Time.timeScale = 0;
			mouseLook.panel = true;
			cursorShow = true;
			//mouseLook.SetCursorLock(true);
			//mouseLook.m_cursorIsLocked = false;
			//mouseLook.InternalLockUpdate ();
			panelactivate = true;
			mouseLook.SetCursorLock (false);

		} else if (coconutNum < -1) {
			//Cursor.visible = true;
			//Cursor.lockState = CursorLockMode.None;
			Time.timeScale = 0;
			LostPanel.SetActive (true);
			cursorShow = true;
			mouseLook.SetCursorLock (false);
			//mouseLook.SetCursorLock(true);
			//mouseLook.InternalLockUpdate ();
			panelactivate = true;

		}
	
		//boxesOnGround++;

		if (Input.GetKey (KeyCode.Space)) {
			//print ("key down" + power);
			if (power < 2000) {
				//print ("add power");
				power += powerInc;
			}
		} 

		if (Input.GetKeyUp (KeyCode.Space)) {
			//fire ();
			//power = powerLevel;
			power = 500;
			coconutNum--;
		}

	}
	public void InActivate(){
		LostPanel.SetActive (false);
		WinPanel.SetActive (false);
	}
	public void Retry(){
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (currentIndex);
	}

	public void MainMenu(){
		//int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene("StartScene");
	}

	public void NextScene(){
		int i = Application.loadedLevel;
		if (i == 3) {
			SceneManager.LoadScene ("StartScene");
		}
		else
			Application.LoadLevel (i + 1);
	}

	/*
	void OnCollisionStay(Collision coll) {
		//if (coll.gameObject.tag != "Untagged")
		//	print (coll.gameObject.tag);

		if (coll.gameObject.CompareTag("boxy") == true) {
			//Destroy (gameObject, 10);

			if (!hashMap.ContainsKey(coll.gameObject.GetInstanceID ())) {
				hashMap.Add (coll.gameObject.GetInstanceID (), 1);
				boxesOnGround++;
				print ("boxes on ground " + boxesOnGround);
			}


		} else {
			//print ("hit a thing");

		}
	}
	*/
}
