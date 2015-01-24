using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SailorButton : MonoBehaviour {
	GameObject sailorgagePanel;
	GameObject sailorboad;
	GameObject sailorResult;
	public Text ResultText;
	public Slider gageslider;
	public bool   gagestop;
	public static bool  fadeout;
	public static bool  resultopen;
	// Use this for initialization
	void Start () {
		sailorgagePanel = GameObject.Find ("gageSlider") as GameObject;
		sailorboad      = GameObject.Find ("SailorminigameBoat") as GameObject;
		sailorResult    = GameObject.Find("sailorResultPanel") as GameObject;
		sailorResult   .SetActive (false);
		sailorgagePanel.SetActive (false);
		sailorboad.     SetActive (false);
		gagestop = true;
		gageslider.value = 0.0f;
		fadeout = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(!gagestop)
		  gagesystem();
		 resultOpen ();
	}

	void gagesystem(){

		gageslider.value += Time.deltaTime * 2;
		if(gageslider.value >= 1)
			gageslider.value = 0.0f;

		if (Input.GetMouseButton (0) && !fadeout){
			fadeout = true;	
			gagestop = true;
			tingyoGetamount();

		}
	}

	public void gageSliderOpen(){
		gagestop = false;
		sailorgagePanel.SetActive (true);
		sailorboad.SetActive (true);
	}

	//sailor migame open
	void   resultOpen(){
		if (resultopen) {
			sailorgagePanel.SetActive (false);
			sailorboad.SetActive (false);
			sailorResult.SetActive(true);
		}
	}

	//minigame get tingyo amount
	void tingyoGetamount(){
		int random = 0;
		//red gage failed patern 
		if (gageslider.value <= 0.15f || gageslider.value >= 0.91f) {
			Savetest.tingyo += 1;
			ResultText.text += "1 匹";
		}
		// green gage normalpatern. 
		else if(gageslider.value > 0.15f && gageslider.value <= 0.79f){
			random = Random.Range(1,3);
			Savetest.tingyo += random;
			ResultText.text += random.ToString() + " 匹";
		}
		else{
			random = Random.Range(4,5);
			Savetest.tingyo += random;
			ResultText.text += random.ToString() + " 匹";
		}

	}
	//Close to sailorPanel
	public void  resultClose(){
		resultopen = false;
		fadeout    = false;
		sailorResult.SetActive(false);
		PlayerUI.Stop = false;
	}

}
