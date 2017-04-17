using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
public class ButtonShoot : Button {
	public UnityStandardAssets.Characters.FirstPerson.FirstPersonController fpc;
//	public UnityStandardAssets.Characters.FirstPerson.FirstPersonController fpc;
	public RectTransform BarBack;
	public RectTransform BarFill;

	private float power = 0f;
	private float n = 0f;


	// Update is called once per frame
	void Update () {
		if (IsPressed ()) {
			n += Time.deltaTime;
			power = Mathf.PingPong (n, 1f);
			BarFill.sizeDelta = new Vector2 (BarBack.sizeDelta.x * power, BarBack.sizeDelta.y);
		} else if (n > 0f) {
			fpc.fire (power * 2000f);
			//fpc.fire (power * 2000f);
			n = 0f;
			power = 0f;
		}
	}
}
*/