using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PilotText : MonoBehaviour {
	public Text timer;
	public Text shotdown_amount;
	public static float timerimit;
	public static int amount;

	GameObject FinishPanel = null;
	// Use this for initialization
	void Start () {
		timerimit = 30;
		FinishPanel = GameObject.Find ("FinishPanel") as GameObject;
		FinishPanel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		TextUpDate ();
		if (!pilotControl.stop && timerimit > 0)
		timerimit -= 1 * Time.deltaTime;

		if(timerimit <= 0){
			FinishPanel.SetActive(true);
			pilotControl.stop = true;

		}
	}

	void TextUpDate(){
		timer.text = timerimit.ToString ();
		shotdown_amount.text = amount.ToString ();
	}
}
