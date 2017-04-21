using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {
	public Text level;
	public Text coconutsLeft;
	public Text powerLevel;
	public Text score;
	public Text score2Beat;

	// Use this for initialization
	void Start () {
		level = GameObject.Find("Level").GetComponent<Text> ();
		coconutsLeft = GameObject.Find("Coconuts Left").GetComponent<Text> ();
		powerLevel = GameObject.Find("Power Level").GetComponent<Text> ();
		score = GameObject.Find("Score").GetComponent<Text> ();
		score2Beat = GameObject.Find("Score to Beat Level").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		level.text = "Level: " + (TerrainBehavior.level).ToString();
		coconutsLeft.text = "Coconuts Left: " + TerrainBehavior.coconutNum;
		powerLevel.text = "Power Level: " + TerrainBehavior.power;
		score.text = "Score: " + (TerrainBehavior.boxesOnGround * 200).ToString ();
		if ((TerrainBehavior.level) == 1) {
			score2Beat.text = "Score to Beat Level: 4800";
		} else if ((TerrainBehavior.level) == 2) {
			score2Beat.text = "Score to Beat Level: 1000";
		} else if ((TerrainBehavior.level) == 3) {
			score2Beat.text = "Score to Beat Level: 1000";
		}
	}
}
