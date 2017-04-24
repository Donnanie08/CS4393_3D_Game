using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactEffect : MonoBehaviour {

	static bool AudioBegin = false; 			

	void Awake()
	{
		if (!AudioBegin) {
			AudioSource source = GetComponent<AudioSource> ();

			source.Play ();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		} 
	}
	/*
	void Update () {
		if((Application.loadedLevel == 1) ||(Application.loadedLevel == 2)||(Application.loadedLevel == 3)||(Application.loadedLevel == 0))
		{
			AudioSource source = GetComponent<AudioSource> ();
			source.Stop();
			AudioBegin = false;
		}
	}
*/
}
