using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;


public class ButtonShoot : MonoBehaviour {
	public FirstPersonController fpc;
	public RectTransform BarBack;
	public RectTransform BarFill;

	private float power = 0f;
	private float n = 0f;
	/*
	if (coconutNum > 0) {
		if (Input.GetKey(KeyCode.Space)) {
			n += Time.deltaTime;
			power = Mathf.PingPong (n, 1);
			BarFill.sizeDelta = new Vector2 (BarBack.sizeDelta.x * power, BarBack.sizeDelta.y);
		} 
		if(Input.GetKeyUp(KeyCode.Space)) {
			fire (power * 2000);
			//fpc.fire (power * 2000f);
			n = 0f;
			power = 0;
		}
	}
*/
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space)) {
			n += Time.deltaTime;
			power = Mathf.PingPong (n, 1f);
			BarFill.sizeDelta = new Vector2 (BarBack.sizeDelta.x * power, BarBack.sizeDelta.y);
		}
		if(Input.GetKeyUp(KeyCode.Space)){
			fpc.fire(power * 2000f);
			//fpc.fire (power * 2000f);
			n = 0f;
			power = 0f;
		}
	}
}

