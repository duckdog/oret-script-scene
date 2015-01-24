using UnityEngine;
using System.Collections;

public class BirdButton : MonoBehaviour {

	GameObject panel = null;
	// Use this for initialization
	void Start () {
		panel = GameObject.Find ("TalkPanel") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GotobirdScene(){
		Application.LoadLevel("torinigenScene");
	}
	public void ClosePanel(){
	  panel.gameObject.SetActive (false);
	  
	}

}
