using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startup : MonoBehaviour {

	public GameObject box;
	public float x;
	public float z;
	public float incY;
	public float incXZ;

	// Use this for initialization
	void Start () {
		
		for (int j = 0; j < 5; j++) {
			Instantiate (box, new Vector3 (incXZ+x, incY+j, z), Quaternion.identity);
			if (j % 2 == 0)
				Instantiate (box, new Vector3 (incXZ+1+x, incY+j, z), Quaternion.identity);
		}
		for (int j = 0; j < 5; j++) {
			Instantiate (box, new Vector3 ((float) x-incXZ, incY+j, z), Quaternion.identity);
			if (j % 2 == 0)
				Instantiate (box, new Vector3 ((float) x-incXZ-1, incY+j, z), Quaternion.identity);
		}
		for (int j = 0; j < 5; j++) {
			Instantiate (box, new Vector3 (x, incY+j, incXZ+z), Quaternion.identity);
			if (j % 2 == 0)
				Instantiate (box, new Vector3 (x, incY+j, incXZ+z+1), Quaternion.identity);
		}
		for (int j = 0; j < 5; j++) {
			Instantiate (box, new Vector3 (x, incY+j, (float) z-incXZ), Quaternion.identity);
			if (j % 2 == 0)
				Instantiate (box, new Vector3 (x, incY+j, (float) z-incXZ-1), Quaternion.identity);
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
