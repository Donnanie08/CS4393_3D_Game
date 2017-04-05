using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainBehavior : MonoBehaviour {

	public static int boxesOnGround;
	public int numberOfBoxes;
	static public Dictionary<int, int> hashMap = new Dictionary<int, int> ();


	// Use this for initialization
	void Start () {
		print (numberOfBoxes);
		boxesOnGround = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (boxesOnGround == numberOfBoxes * 2 / 3) {
			print ("You Win!");

			boxesOnGround++;
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
