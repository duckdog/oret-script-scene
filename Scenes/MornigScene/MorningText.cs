using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MorningText : MonoBehaviour {

	public Text[] paytext = new Text[3]; 
	public Text[] gettext = new Text[2];
	public int[] payinfo = new int[10];
	private  int count = 0;
	private GameObject paytextpanel;
	private GameObject gettextpanel;
	// Use this for initialization
	void Start () {
		Payinfo ();
		//To call clone name 
		GameObject function = GameObject.Find ("TextData") as GameObject;
		function.GetComponent<TextTest>().CloneName();
		textUpDate ();
		GetItem ();
		paytextpanel = GameObject.Find ("PayText") as GameObject;
		gettextpanel = GameObject.Find ("GetText") as GameObject;
		gettextpanel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//  to give payinfo ;
	public void Payinfo(){
		payinfo [0] = 10;
		payinfo [1] = 15;
		payinfo [2] = 20;
		payinfo [3] = 25;
		payinfo [4] = 25;
		payinfo [5] = 30;
		payinfo [6] = 30;
		payinfo [7] = 50;
		payinfo [8] = 1;
		payinfo [9] = 15;

	}

	//text update
	public void textUpDate() {
		int totalnumber = 0;
		for(int i = 0; i <10; i++){
			//Savetest.money += payinfo[i] * Savetest.clone_amount[i];
			if(Savetest.clone_amount[i] >0){
			    paytext[0].text += TextTest.clonesName[i] + "\n";
				paytext[1].text += Savetest.clone_amount[i].ToString() + "×  " + payinfo[i].ToString() + "ｶｽﾔ\n";
				Savetest.money  +=  Savetest.clone_amount[i] * payinfo[i];
				totalnumber     +=  Savetest.clone_amount[i] * payinfo[i];
			}
		}
		paytext[2].text += totalnumber.ToString () + "ｶｽﾔ\n";

	}	

	public void NextButton(){
		count++;
		paytextpanel.SetActive (false);
		gettextpanel.SetActive (true);
		if (count == 2) {
			count = 0;
			Application.LoadLevel("MakeClone");
		}
	}
	public void GetItem(){
		for(int i = 0; i < 10; i++){
			if(Savetest.clone_amount[i] >0){
				int random2;

				switch(i){
				case 0:
					random2 = Random.Range(0,5 + Savetest.clone_amount[i]);
					int random1 = Random.Range(0,3);
					if(random2 > 0){
						if(random1 == 1){
							gettext[0].text += CloneDate.Name.biseibutu+ "\n";
							Savetest.biseibutu += random2;
						}
						else if(random1 == 2){
							gettext[0].text += CloneDate.Name.syokubutu+ "\n";
							Savetest.biseibutu += random2;
						}
						else{
							gettext[0].text += CloneDate.Name.kajitu+ "\n";
							Savetest.biseibutu += random2;
						}
						if(random1 == 1)
							gettext[1].text += random2.ToString() + "体\n";
						else
						    gettext[1].text += random2.ToString() + "個\n";
					}
					break;
				case 1:

					random2 = Random.Range(0,5 + Savetest.clone_amount[i]);
					if(random2 > 0){
						gettext[0].text += CloneDate.Name.tikaranotane+ "\n";
						gettext[1].text +=random2.ToString() + "個\n";
					Savetest.tikaranotane += random2;
					}
					if((random2 - 2) > 0 ){
						random2 -= 2;
						gettext[0].text += CloneDate.Name.tiseinotane+ "\n";
						gettext[1].text += random2.ToString()+ "個\n";

						Savetest.tiseinotane += random2;
					}
					break;
				case 2:
					random2 = Random.Range(0,5 + Savetest.clone_amount[i]);
					if(random2 > 0){
						gettext[0].text += CloneDate.Name.tetukuzu +"\n";
						gettext[1].text += random2.ToString() + "個\n";
						Savetest.tetukuzu += random2;
					}
					break;
				case 3:
					random2 = Random.Range(0,(1 + Savetest.clone_amount[4] * 3));
					if(random2 > 0){
						gettext[0].text    += CloneDate.Name.tingyo + "\n";
						gettext[1].text    += random2.ToString() + "魚\n";
						Savetest.tingyo += random2; 
					}
					break;
//				case 4:
//					
//					break;
				case 5:
					random2 = Random.Range(0,3 + Savetest.clone_amount[5]);
					if(random2 > 0){
					 gettext[0].text += CloneDate.Name.toriniku + "\n";
						gettext[1].text += random2.ToString() + "個\n";
						Savetest.toriniku += random2;
					}
					break;
//				case 6:
//					
//					break;
//				case 7:
//					
//					break;
				case 8:
					random2 = Random.Range(0,10 + Savetest.clone_amount[8]);
					if(random2 > 0){
						gettext[0].text += CloneDate.Name.feromon + "\n";
						gettext[1].text += random2.ToString() + "個\n";
						Savetest.feromon += random2;
					}
					break;
				}


			}
		}
	}
}
