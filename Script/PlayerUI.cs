using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PlayerUI : MonoBehaviour {

	// sale
	GameObject   MessegePanel  = null;
	GameObject   FoundPanel    = null;
	GameObject   SyojiPanel    = null;
    GameObject   TalkPanel     = null;
	//bird
	GameObject   BirdText      = null;
	GameObject   BirdResltPanel = null;
	//sailor
	GameObject  SailorText_Gage = null;
	public static bool playafter_sailor;
	//Famer
	GameObject FamerText       = null;
	public static bool playafter_famer;

	// states HP(timer),stopmove,etc... 
	public Slider slider     = null;
	public static bool Stop  = false;
	public static float lifespeed;
	public static float life = 0.0f;
	public static bool  timeover_fadeout;
	GameObject          timeover_text;

	//don't move position 
	public void StopPosition(){
		Stop = false;
		FoundPanel.SetActive(true);
		MessegePanel.SetActive(false);
		SyojiPanel.SetActive  (false);
		TalkPanel.SetActive   (false);
		SailorText_Gage.SetActive (false);
		FamerText.SetActive (false);
	}

	public void OpenSyojiPanel(){
		SyojiPanel.SetActive(true);
	}
	// Use this for initialization
	void Start () {
		slider.value -= life;
		Debug.Log(life +" life");
		lifespeed = 0.01f;
		MessegePanel    = GameObject.Find ("MessegePanel")     as GameObject;
		FoundPanel      = GameObject.Find ("FoundPanel"  )     as GameObject;
		SyojiPanel      = GameObject.Find ("SyojiPanel"  )     as GameObject;
		TalkPanel       = GameObject.Find ("TalkPanel")        as GameObject;
		BirdResltPanel  = GameObject.Find ("ResultPanel")      as GameObject;
		BirdText        = GameObject.Find ("birdText")         as GameObject;
		SailorText_Gage = GameObject.Find ("SailorText")       as GameObject;
		timeover_text   = GameObject.Find ("timeover_fadeoutText")   as GameObject;
		FamerText       = GameObject.Find ("FamerText") as GameObject;



 		MessegePanel.SetActive (false);
		FoundPanel.SetActive   (false);
		SyojiPanel.SetActive   (false);
		TalkPanel.SetActive    (false);
		BirdText.SetActive (false);
		BirdResltPanel.SetActive (false);
		if (TextData.playafter && !TextData.Birdresult_opend)
			BirdResltPanel.SetActive  (true);
		SailorText_Gage.SetActive (false);
		timeover_text.SetActive (false);
		FamerText.SetActive (false);

	}

	
	// Update is called once per frame
	void Update () { 

		if(!PlayerUI.Stop)
		lifemater ();
	}

	// life down system;
	public void lifemater(){
		slider.value -= lifespeed * Time.deltaTime;
		life += lifespeed * Time.deltaTime;
		if(slider.value == 0.0f) {
			timeover_fadeout = true;
			timeover_text.SetActive(true);
		}
	}
	//Pilot close to resultPanel
	public void Closeresult(){
		BirdResltPanel.SetActive (false);
		PlayerUI.Stop = false;
	}

	
   //sailor start minigame Buttons
	public void  SailorpanelClose(){
		TalkPanel.SetActive(false);
		playafter_sailor = true;
		Fadeinout.alpha = 0.0f;
	}


	// Foundpanel("hanasi kakeru") open.
	void OnTriggerEnter(Collider other){
		
		if (other.gameObject.tag == "Sales" || 
		    other.gameObject.tag == "Bird"  ||
		    other.gameObject.tag == "Sailor"||
		    other.gameObject.tag == "Famer")
			FoundPanel.SetActive(true);

	}
	
	void OnTriggerStay(Collider other){
		if (other.gameObject.tag == "Sales" && Input.GetMouseButton(0)){
			FoundPanel.SetActive(false);
			MessegePanel.SetActive(true);
			Stop = true;
		} 
		// Bird Button function
		if (Input.GetMouseButton (0)) {
			if(other.gameObject.tag == "Bird" && !TextData.playafter){
				FoundPanel.SetActive(false);
				TalkPanel.SetActive(true);
				BirdText.SetActive(true);
				Stop = true;
			}		
		}
		// sailor Button funcion 
		if (Input.GetMouseButton (0)) {
			if(other.gameObject.tag == "Sailor" && !playafter_sailor){

				FoundPanel.SetActive(false);
				TalkPanel.SetActive (true);
				SailorText_Gage.SetActive(true);
				Stop = true;
			}		
		}
		if (Input.GetMouseButton (0)) {
			if(other.gameObject.tag == "Famer"){
				
				FoundPanel.SetActive(false);
				TalkPanel.SetActive (true);
				FamerText.SetActive(true);
				Stop = true;
			}		
		}

	}
	void OnTriggerExit(Collider other){
		FoundPanel.SetActive(false);
		Stop = false;
	}
}
