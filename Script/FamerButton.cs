using UnityEngine;
using System.Collections;

public class FamerButton : MonoBehaviour {
	// what to choice material
	public static bool choose_tikara;
	public static bool choose_tisei;
	public static bool choose_oretrice;
	//jading do or did   
	public static bool Famer_finshcultivation;

	//famer
	GameObject Famer_DocultivaitionPanel;
	GameObject Famer_DidculitvationPanel;
	// Use this for initialization
	void Start () {
		//test 
		Famer_finshcultivation = false;

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
