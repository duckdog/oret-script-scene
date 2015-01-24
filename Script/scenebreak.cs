using UnityEngine;
using System.Collections;using UnityEngine.UI;


public class scenebreak : MonoBehaviour {

	GameObject panel = null;
	GameObject howtopanel = null;

	// Use this for initialization
	void Start () {
		panel = GameObject.Find ("breakPanel") as GameObject;
		howtopanel = GameObject.Find ("HowtoPanel") as GameObject;
		panel.SetActive (false);
		howtopanel.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnColliderEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			panel.SetActive(true);
			pilotControl.stop = true;
		}
	}

	public void restart(){
		panel.SetActive(false);
		pilotControl.stop = false;
		pilotControl.count = 0;
	}

	public void pause(){
		panel.SetActive(true);
		pilotControl.stop = true;

	}


	public void Readygo(){
		howtopanel.SetActive(false);
		pilotControl.stop = false;
	}

}
