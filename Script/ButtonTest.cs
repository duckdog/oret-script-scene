using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonTest : MonoBehaviour {
	private GameObject MainW;
	private GameObject ToolW;

	// Use this for initialization
	void Start () {
		MainW = GameObject.Find ("MainWindow");
		ToolW = GameObject.Find("ToolWindow");
		ToolW.GetComponent<Canvas> ().enabled = false;
	}

	//Open makeclone window
	public void OpenToolWindow(){
		ToolW.GetComponent<Canvas> ().enabled = true;
		MainW.GetComponent<Canvas> ().enabled = false;
	}
	//Close makeclone Window
	public void CloseToolWindow(){
		ToolW.GetComponent<Canvas>().enabled = false;
		MainW.GetComponent<Canvas> ().enabled = true;
	}

	// exit to gameScene
	public void ExitGameScene(){
		Application.LoadLevel("GameScene");
	}

	// Update is called once per frame
	void Update () {
	
	}
}
