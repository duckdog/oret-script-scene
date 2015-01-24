using UnityEngine;
using System.Collections;

public class titleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnGUI(){
		if (GUI.Button (new Rect (Screen.width / 2, Screen.height / 2, 100, 100), "title")) {
			Application.LoadLevel("MakeClone");
		}
	}

	// Update is called once per frame
	void Update () {
	 
	}
}
