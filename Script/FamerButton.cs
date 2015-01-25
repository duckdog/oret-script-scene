using UnityEngine;
using System.Collections;

public class FamerButton : MonoBehaviour {
	// what to choice material
	public static bool choose_tikara;
	public static bool choose_tisei;
	public static bool choose_oretrice;
	//jading do or did   
	public static bool Famer_finshcultivation = false;

	//famer
	GameObject Famer_cultivationPanel    = null;
	GameObject Famer_DocultivaitionPanel = null;
	GameObject Famer_DidcultivationPanel = null;
	// Use this for initialization
	void Start () {
		//test 
		Famer_finshcultivation = false;

		Famer_cultivationPanel    = GameObject.Find("F_cultivationPanel") as GameObject;
		Famer_DocultivaitionPanel = GameObject.Find("F_do")               as GameObject;
		Famer_DidcultivationPanel = GameObject.Find("F_did")              as GameObject;
	
		Famer_cultivationPanel.SetActive (false);
		Famer_DocultivaitionPanel.SetActive (false);
		if(Famer_finshcultivation)
		Famer_DidcultivationPanel.SetActive (false);
		else
		Famer_DidcultivationPanel.SetActive(true);


	}
	
	// Update is called once per frame
	void Update () {

	}
	//
	public void choosing_tikara  (){ choose_tikara     = true;}
	public void choosing_tisei   (){ choose_tisei      = true;}
	public void choosing_oretrice(){ choose_oretrice   = true;}

	//choosed after system
	public void choosed(){
		if(choose_tikara || choose_tisei ||
		   choose_oretrice                ){
			Famer_finshcultivation = true;
		}
	}
	// if closed resultpanel,riset bool choose; 
	public void choose_riset(){
		choose_tikara          = false;
		choose_tisei           = false;
		choose_oretrice        = false;
		Famer_finshcultivation = false;
	}
}
