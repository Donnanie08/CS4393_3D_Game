using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehavior : MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision coll) {
		if (coll.gameObject.CompareTag("terra") == true) {
			//Destroy (gameObject, 5);
			if (!TerrainBehavior.hashMap.ContainsKey(gameObject.GetInstanceID ())) {
				TerrainBehavior.hashMap.Add (gameObject.GetInstanceID (), 1);
				TerrainBehavior.boxesOnGround++;
				print ("boxes on ground " + TerrainBehavior.boxesOnGround);
			}
			//print ("hit a thing " + gameObject.GetInstanceID());
		} else {
			//print ("hit a thing");
		}
	}

}
