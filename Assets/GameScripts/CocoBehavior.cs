using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocoBehavior : MonoBehaviour {

	public Collider collide;
	private Rigidbody rb;
	private int lifetime;

	// Use this for initialization
	void Start () {
		//rb.useGravity = true;
		rb = GetComponent<Rigidbody>();
		Destroy (gameObject, 6);
		//lifetime = 600;
	}

	void onTriggerEnter(Collider other) {
		
	}
	
	// Update is called once per frame
	void Update () {
		//rb.AddForce (Physics.gravity);
		/*
		if (lifetime == 0) {
			Destroy (gameObject);
		} else {
			lifetime -= 1;
		}
		*/
	}

	void OnDestroy () {
		TerrainBehavior.coconutsDestroyed++;
	}
}
