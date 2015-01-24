using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {
	bool pause_on = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		if (!pause_on && GUI.Button (new Rect (600, 20, 100, 50), "ポーズ")) {

			Application.LoadLevelAdditive("pauseScene");
			pause_on = true;
		}
		if (pause_on && GUI.Button (new Rect (600, 20, 100, 50), "再開")) {
			
			Application.LoadLevel("makeClone");
			pause_on = false;
		}
	}
}
