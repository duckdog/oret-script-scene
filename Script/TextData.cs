using UnityEngine;
using System.Collections;
using UnityEngine.UI;	// uGUIの機能を使うお約束
public class TextData : MonoBehaviour {
	private string[] syoji           = new string[13];
	private string[] syoji_amount    = new string[13];
	private int[] muchinfo = new int[11];
	public static int amount;
	public  int much;
	public static bool playafter = false;
	public static bool Birdresult_opend;

	//
	public Text Syojiui;
	public Text Syoji_aui;
	public Text[] TEST  = new Text[13];

	public Text sales_amount;
	public Text sales;
	public Text kasuya;//money's name  
	//bird 
	public Text[] bird_text = new Text[2];
	//famer
	public Text   famerresult;
	// Use this for initialization
	void Start () {
		amount = 0;
		Muchinfo ();
		moneyUpDate ();
		if(playafter)
		birdTextUpDate ();
		syoji [0]  = CloneDate.Name.kaminoke +"\n";
		syoji [1]  = CloneDate.Name.syokubutu+"\n";
		syoji [2]  = CloneDate.Name.kajitu   +"\n";
		syoji [3]  = CloneDate.Name.biseibutu+"\n";
		syoji [4]  = CloneDate.Name.tikaranotane+"\n";
		syoji [5]  = CloneDate.Name.hosinokakera+"\n";
		syoji [6]  = CloneDate.Name.tetukuzu+"\n";
		syoji [7]  = CloneDate.Name.tingyo+"\n";
		syoji [8]  = CloneDate.Name.tiseinotane+"\n";
		syoji [9]  = CloneDate.Name.nekutai +"\n";
		syoji [10] = CloneDate.Name.toriniku +"\n";
		syoji [11] = CloneDate.Name.feromon+"\n";
		syoji [12] = CloneDate.Name.hosi +"\n";
		syoji_amount [0]  = Savetest.kaminoke.ToString()    +"\n";
		syoji_amount [1]  = Savetest.syokubutu.ToString()   +"\n";
		syoji_amount [2]  = Savetest.kajitu.ToString()      +"\n";
		syoji_amount [3]  = Savetest.biseibutu.ToString()   +"\n";
		syoji_amount [4]  = Savetest.tikaranotane.ToString()+"\n";
		syoji_amount [5]  = Savetest.hosinokakera.ToString()+"\n";
		syoji_amount [6]  = Savetest.tetukuzu.ToString()    +"\n";
		syoji_amount [7]  = Savetest.tingyo.ToString()      +"\n";
		syoji_amount [8]  = Savetest.tiseinotane.ToString() +"\n";
		syoji_amount [9]  = Savetest.nekutai.ToString()     +"\n";
		syoji_amount [10] = Savetest.toriniku.ToString()    +"\n";
		syoji_amount [11] = Savetest.feromon.ToString()     +"\n";
		syoji_amount [12] = Savetest.hosi.ToString()        +"\n";

		for (int i = 0; i < 13; i++) {
			if(i == 5 || i == 9 ) continue;
						TEST [i].text = syoji [i];
		}
//		Syoji_aui.text = syoji_amount [0] + syoji_amount [1]  + syoji_amount[2]
//		+ syoji_amount[3] + syoji_amount[4] + syoji_amount[5]+ syoji_amount[6]
//		+ syoji_amount[7]+ syoji_amount[8]+ syoji_amount[9]+ syoji_amount[10]
//		+ syoji_amount[11]+ syoji_amount[12];
//
//		Syojiui.text = syoji [0] + syoji [1]  + syoji[2] + syoji[3] + syoji[4] 
//		+ syoji[5]+ syoji[6]+ syoji[7]+ syoji[8]+ syoji[9]+ syoji[10]
//		+ syoji[11]+ syoji[12];
	}
	public void salesTextUpData(){
		SaleSystem ();
 		switch (SalesButtons.ItemNumber) {
		case 0:
			sales.text = syoji[0] + syoji_amount[0];
			break;
		case 1:
			sales.text = syoji[1]+ syoji_amount[1];
			break;
		case 2:
			sales.text = syoji[2]+ syoji_amount[2];
			break;
		case 3:
			sales.text = syoji[3]+ syoji_amount[3];
			break;
		case 4:
			sales.text = syoji[4]+ syoji_amount[4];
			break;
		case 5:
			sales.text = syoji[6]+ syoji_amount[6];
			break;
		case 6:
			sales.text = syoji[7]+ syoji_amount[7];
			break;
		case 7:
			sales.text = syoji[8]+ syoji_amount[8];
			break;
		case 8:
			sales.text = syoji[10]+ syoji_amount[10];
			break;
		case 9:
			sales.text = syoji[1]+ syoji_amount[11];
			break;
		case 10:
			sales.text = syoji[12]+ syoji_amount[12];
			break;
		
		}
	}


	void Muchinfo(){
		muchinfo[0] = 1;
		muchinfo[1] = 20;
		muchinfo[2] = 20;
		muchinfo[3] = 20;
		muchinfo[4] = 20;
		muchinfo[5] = 100;
		muchinfo[6] = 30;
		muchinfo[7] = 200;
		muchinfo[8] = 150;
		muchinfo[9] = 500;
		muchinfo[10] = 1;
	}

	public void SaleSystem(){

		much = (amount * muchinfo[SalesButtons.ItemNumber]); 
		sales_amount.text = much.ToString()+"カスヤ         " + amount.ToString(); 

	}
//	void life(){
//		this.image.type.
//	}

	public void Saling(){
		Savetest.money += much;
		switch(SalesButtons.ItemNumber){
		case 0:
			Savetest.kaminoke     -= amount;
			break;
		case 1:
			Savetest.syokubutu    -= amount;
			break;
		case 2:
			Savetest.kajitu       -= amount;
			break;
		case 3:
			Savetest.biseibutu    -= amount;
			break;
		case 4:
			Savetest.tikaranotane -= amount;
			break;
		case 5:
			Savetest.tetukuzu     -= amount;
			break;
		case 6:
			Savetest.tingyo       -= amount;
			break;
		case 7:
			Savetest.tiseinotane  -= amount;
			break;
		case 8:
			Savetest.toriniku     -= amount;
			break;
		case 9:
			Savetest.feromon     -= amount;
			break;
		case 10:
			Savetest.hosi        -= amount;
			break;
		}
		syoji_amount [0]  = Savetest.kaminoke.ToString()    +"\n";
		syoji_amount [1]  = Savetest.syokubutu.ToString()   +"\n";
		syoji_amount [2]  = Savetest.kajitu.ToString()      +"\n";
		syoji_amount [3]  = Savetest.biseibutu.ToString()   +"\n";
		syoji_amount [4]  = Savetest.tikaranotane.ToString()+"\n";
		syoji_amount [5]  = Savetest.hosinokakera.ToString()+"\n";
		syoji_amount [6]  = Savetest.tetukuzu.ToString()    +"\n";
		syoji_amount [7]  = Savetest.tingyo.ToString()      +"\n";
		syoji_amount [8]  = Savetest.tiseinotane.ToString() +"\n";
		syoji_amount [9]  = Savetest.nekutai.ToString()     +"\n";
		syoji_amount [10] = Savetest.toriniku.ToString()    +"\n";
		syoji_amount [11] = Savetest.feromon.ToString()     +"\n";
		syoji_amount [12] = Savetest.hosi.ToString()        +"\n";
		salesTextUpData ();
		moneyUpDate ();

	}

	public void moneyUpDate (){
		kasuya.text = Savetest.money.ToString ();
	}

	public void birdTextUpDate(){
		//dont opend
		if(!Birdresult_opend){
			float prass = 0;
			int feromon = 0;
			prass = (float)PilotText.amount * 0.25f;
			feromon = Random.Range (1, (2 + (int)prass));
			bird_text [0].text += (PilotText.amount * 10).ToString() +"カスヤ";
			bird_text [1].text += feromon.ToString();
			Savetest.money += PilotText.amount * 10;
			Savetest.feromon += feromon;
			Birdresult_opend = true;
		}
	}

	//famar cultivation result text.
	public void Famer_TextUpDate(){
		//famerresult.text 
	}


	public  void TextUpdate()
	{
//		Syojiui.text = syoji [0] + syoji [1]  + syoji[2] + syoji[3] + syoji[4] 
//				+ syoji[5]+ syoji[6]+ syoji[7]+ syoji[8]+ syoji[9]+ syoji[10]
//				+ syoji[11]+ syoji[12];
//		Syoji_aui.text = syoji_amount [0] + syoji_amount [1]  + syoji_amount[2]
//		+ syoji_amount[3] + syoji_amount[4] + syoji_amount[5]+ syoji_amount[6]
//		+ syoji_amount[7]+ syoji_amount[8]+ syoji_amount[9]+ syoji_amount[10]
//		+ syoji_amount[11]+ syoji_amount[12];
		
	}
	// Update is called once per frame
	void Update () {
	
	}
}
