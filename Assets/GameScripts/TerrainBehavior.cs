using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerrainBehavior : MonoBehaviour {

	public static int boxesOnGround;
	public int numberOfBoxes;
	static public Dictionary<int, int> hashMap = new Dictionary<int, int> ();
	static public int level;
	public int thisLevel;
	static public int power;
	static public int coconutNum;
	public int powerInc;

	// Use this for initialization
	void Start () {
		//print (numberOfBoxes);
		boxesOnGround = 0;
		coconutNum = 5;
		power = 500;
		powerInc = 10;
		level = thisLevel;
	}
	
	// Update is called once per frame
	void Update () {
		if (boxesOnGround == numberOfBoxes * 3 / 4) {
			if (level == 1) {
				SceneManager.LoadScene ("Level2Scene");
			} else if (level == 2) {
				SceneManager.LoadScene ("Level3Scene");
			} else {
				SceneManager.LoadScene(0);
			}

			//boxesOnGround++;
		}

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
