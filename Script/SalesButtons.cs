using UnityEngine;
using System.Collections;

public class SalesButtons : MonoBehaviour {

	private GameObject[] salesButton = new GameObject[11];
	public static GameObject   salesPanel;
	public static  int   ItemNumber;



	// Use this for initialization
	void Start () {
		salesButton[0]  = GameObject.Find ("kaminokeButton")      as GameObject;
		salesButton[1]  = GameObject.Find ("syokubutuButton")     as GameObject;
		salesButton[2]  = GameObject.Find ("kajituButton")        as GameObject;
		salesButton[3]  = GameObject.Find ("biseibutuButton")     as GameObject;
		salesButton[4]  = GameObject.Find ("tiakaranotaneButton") as GameObject;
		salesButton[5]  = GameObject.Find ("tetukuzuButton")      as GameObject;
		salesButton[6]  = GameObject.Find ("tingyoButton")        as GameObject;
		salesButton[7]  = GameObject.Find ("tiseinotaneButton")   as GameObject;
		salesButton[8]  = GameObject.Find ("torinikuButton")      as GameObject;
		salesButton[9]  = GameObject.Find ("feromonButton")       as GameObject;
		salesButton[10] = GameObject.Find ("hosiButton")          as GameObject;

		salesPanel = GameObject.Find ("SalesPanel") as GameObject;
		salesPanel.SetActive (false);

	}


	public void SalePanelOpen0(){
		ItemNumber = 0;
		salesPanel.SetActive (true);
	}
	public void SalePanelOpen1(){
		ItemNumber = 1;
		salesPanel.SetActive (true);
	}
	public void SalePanelOpen2(){
		ItemNumber = 2;
		salesPanel.SetActive (true);
	}
	public void SalePanelOpen3(){
		ItemNumber = 3;
		salesPanel.SetActive (true);
	}
	public void SalePanelOpen4(){
		ItemNumber = 4;
		salesPanel.SetActive (true);
	}
	public void SalePanelOpen5(){
		ItemNumber = 5;
		salesPanel.SetActive (true);
	}
	public void SalePanelOpen6(){
		ItemNumber = 6;
		salesPanel.SetActive (true);
	}

	public void SalePanelOpen7(){
		ItemNumber = 7;
		salesPanel.SetActive (true);
	}
	public void SalePanelOpen8(){
		ItemNumber = 8;
		salesPanel.SetActive (true);
	}
	public void SalePanelOpen9(){
		ItemNumber = 9;
		salesPanel.SetActive (true);
	}
	public void SalePanelOpen10(){
		ItemNumber = 10;
		salesPanel.SetActive (true);
	}

	public void SalePanelClose(){
		salesPanel.SetActive (false);
		TextData.amount = 0;
	}

	public void SalecountUp(){
		int rimit = 0;
		switch (ItemNumber) {
		case 0:
			rimit = Savetest.kaminoke;
			break;
		case 1:
			rimit = Savetest.syokubutu;
			break;
		case 2:
			rimit = Savetest.kajitu;
			break;
		case 3:
			rimit = Savetest.biseibutu;
			break;
		case 4:
			rimit = Savetest.tikaranotane;
			break;
		case 5:
			rimit = Savetest.tetukuzu;
			break;
		case 6:
			rimit = Savetest.tingyo;
			break;
		case 7:
			rimit = Savetest.tiseinotane;
			break;
		case 8:
			rimit = Savetest.toriniku;
			break;
		case 9:
			rimit = Savetest.feromon;
			break;
		case 10:
			rimit = Savetest.hosi;
			break;
		}

		TextData.amount++;
		if(rimit < TextData.amount) TextData.amount = 0;

	}

	public void SalecountDown(){
		int rimit = 0;
		switch (ItemNumber) {
		case 0:
			rimit = Savetest.kaminoke;
			break;
		case 1:
			rimit = Savetest.syokubutu;
			break;
		case 2:
			rimit = Savetest.kajitu;
			break;
		case 3:
			rimit = Savetest.biseibutu;
			break;
		case 4:
			rimit = Savetest.tikaranotane;
			break;
		case 5:
			rimit = Savetest.tetukuzu;
			break;
		case 6:
			rimit = Savetest.tingyo;
			break;
		case 7:
			rimit = Savetest.tiseinotane;
			break;
		case 8:
			rimit = Savetest.toriniku;
			break;
		case 9:
			rimit = Savetest.feromon;
			break;
		case 10:
			rimit = Savetest.hosi;
			break;
		}

		TextData.amount--;
		if(0 > TextData.amount) TextData.amount = rimit;
	}
		



	// Update is called once per frame
	void Update () {
	
	}
}
