using UnityEngine;
using System.Collections;

public class skipScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		Clone.open = false;
	}
	void OnGUI(){
		Debug.Log (Clone.open);
		if (!Clone.open) {
						if (GUI.Button (new Rect (Screen.width - 100, Screen.height - 100, 100, 100), "飛ばして戻る")) {
								Application.LoadLevel ("MakeClone");
						}
				} else { 
			if (GUI.Button (new Rect (Screen.width - 100, Screen.height - 100, 100, 100), "戻る")) {
				//Clone.open = false;
				Application.LoadLevel ("MakeClone");

			}
		}
	}
	// Update is called once per frame
	void Update () {
	
	}

}
