using UnityEngine;
using System.Collections;
using UnityEngine.UI;	// uGUIの機能を使うお約束

public class TextTest : MonoBehaviour {

	public  string[] scenarios  = new string[10]; // シナリオを格納する
	public  string[] sozai      = new string[10];
	public  string[] syoji      = new string[10];
	public  static string[] clonesName = new string[10];    

	public Text uiText;	// uiTextへの参照を保つ
	public Text uiSozai;
	public Text uiSyoji;
	public Text clone_amoText;

	public struct  Syoji{
	public static string kaminoke;
	public static string syokubutu;
	public static string kajitu;
	public static string biseibutu;
	public static string tikaranotan;
	public static string hosinokakera;
	public static string tetukuzu;
	public static string tingyo;
	public static string tiseinotane;
	public static string nekutai;
	public static string toriniku;
	public static string feromon;
	public static string hosi;
	}
	int MAX_models =  10; 
	public static int currentLine = 9; // 現在の行番号

	CloneDate clonedata;
	void Start()
	{	
		currentLine = 9;
		SyojiImport ();
		TextSozaiSyojiData ();
		TextUpdate();
		CloneName ();


	}
	
	void Update () 
	{
		Debug.Log ("kaminoke" + Syoji.kaminoke);
		// 現在の行番号がラストまで行ってない状態でクリックすると、テキストを更新する
//		if(currentLine < scenarios.Length && Input.GetMouseButtonDown(0))
//		{
//			TextUpdate();
//		}
	}
	// テキストを更新する
	public void TextUpdate()
	{
	
		// 現在の行のテキストをuiTextに流し込み、現在の行番号を一つ追加する
		++currentLine;
		if (currentLine > MAX_models - 1)
			currentLine = 0;
		//if don't have this currentLine number's clone.
		if(Savetest.clone_amount[currentLine] == 0)
			uiText.text = "? ? ? ";
		else
		    uiText.text = scenarios[currentLine];

		uiSozai.text = sozai [currentLine];
		uiSyoji.text = syoji [currentLine];
		clone_amoText.text = Savetest.clone_amount [currentLine].ToString();
		
		
	}
	public void TextDowndate()
	{
		// 現在の行のテキストをuiTextに流し込み、現在の行番号を一つ追加する
		--currentLine;
		if (currentLine < 0)
			currentLine = MAX_models - 1;
		uiText.text  = scenarios[currentLine];
		uiSozai.text = sozai [currentLine];
		uiSyoji.text = syoji [currentLine];
		clone_amoText.text = Savetest.clone_amount [currentLine].ToString();
		
		
	}

	public void TextSozaiSyojiData(){
		sozai[0] = CloneDate.Name.kaminoke + " 200個\n";
		syoji[0] = Syoji.kaminoke;

		sozai[1] = CloneDate.Name.kaminoke + " 200個\n"+
			       CloneDate.Name.kajitu   + " 20個\n" +
				   CloneDate.Name.syokubutu + " 100個\n";
		syoji[1] = Syoji.kaminoke  + "\n" +
			       Syoji.kajitu    + "\n" +
				   Syoji.syokubutu + "\n";

		sozai[2] = CloneDate.Name.kaminoke     + " 200個\n"+
				   CloneDate.Name.biseibutu    + " 20個\n" +
				   CloneDate.Name.tikaranotane + " 10個\n";
		syoji[2] = Syoji.kaminoke    + "\n" +
			       Syoji.biseibutu   + "\n" +
				   Syoji.tikaranotan + "\n";


		sozai[3] = CloneDate.Name.kaminoke     + " 800個\n"+
			       CloneDate.Name.tikaranotane + " 50個\n" +
				   CloneDate.Name.hosinokakera + " 1個\n";
		syoji[3] = Syoji.kaminoke     + "\n" +
			       Syoji.tikaranotan  + "\n" +
				   Syoji.hosinokakera + "\n";


		sozai[4] = CloneDate.Name.kaminoke     + " 400個\n"+
			       CloneDate.Name.biseibutu    + " 100個\n" +
				   CloneDate.Name.tikaranotane + "  5個\n" +
			       CloneDate.Name.tetukuzu     + " 50個\n" +
				   CloneDate.Name.tingyo       + " 5個\n";
		syoji[4] = Syoji.kaminoke     + "\n" +
			       Syoji.biseibutu    + "\n" +
				   Syoji.tikaranotan  + "\n" +
				   Syoji.tetukuzu     + "\n" +
				   Syoji.tingyo       + "\n";
		 
		sozai[5] = CloneDate.Name.kaminoke     + " 200個\n"+
			       CloneDate.Name.syokubutu     + " 100個\n" +
				   CloneDate.Name.kajitu       + " 100個\n" +
			       CloneDate.Name.biseibutu    + " 100個\n" +
				   CloneDate.Name.tikaranotane + " 5個\n"   +
				   CloneDate.Name.tingyo       + " 10個\n";
		syoji[5] = Syoji.kaminoke     + "\n" +
			       Syoji.syokubutu    + "\n" +
				   Syoji.kajitu       + "\n" +
				   Syoji.biseibutu    + "\n" +
				   Syoji.tikaranotan  + "\n" +
				   Syoji.tingyo       + "\n";

		sozai[6] = CloneDate.Name.kaminoke     + " 200個\n"+
			       CloneDate.Name.biseibutu    + " 300個\n" +
				   CloneDate.Name.tiseinotane  + " 200個\n";
		syoji[6] = Syoji.kaminoke     + "\n" +
			       Syoji.biseibutu    + "\n" +
				   Syoji.tiseinotane  + "\n";

		sozai[7] = CloneDate.Name.kaminoke     + " 200個\n"+
			       CloneDate.Name.tiseinotane  + " 500個\n" +
				   CloneDate.Name.tingyo       +   "  10個\n"+
			       CloneDate.Name.nekutai      + " 1個\n";
		syoji[7] = Syoji.kaminoke     + "\n" +
			       Syoji.tiseinotane  + "\n" +
				   Syoji.tingyo       + "\n"+
				   Syoji.nekutai      + "\n";
				   
		sozai[8] = CloneDate.Name.kaminoke   + " 10000個\n" +
			       CloneDate.Name.toriniku   + " 100個\n";
		syoji[8] = Syoji.kaminoke     + "\n" +
			       Syoji.toriniku     + "\n"; 
				   
		sozai[9] = CloneDate.Name.kaminoke    + " 10個\n"+
			       CloneDate.Name.kajitu      + " 500個\n" +
				   CloneDate.Name.tiseinotane + " 500個\n"+
			       CloneDate.Name.tingyo      + " 100個\n" +
				   CloneDate.Name.feromon     + " 100個\n";
		syoji[9] = Syoji.kaminoke     + "\n" +
			       Syoji.kajitu       + "\n" +
				   Syoji.tiseinotane  + "\n" +
				   Syoji.tingyo       + "\n" +
				   Syoji.feromon      + "\n";


	}

	//making clonebutton 
	public void Need(){
		//ノーマルクローン.
		switch(currentLine){
		case 0:{
			if(Savetest.kaminoke >= 200){
			  Savetest.kaminoke -= 200;
			  Savetest.clone_amount[0] += 1;
			  Application.LoadLevel("MakeEffectScene");
			}
		}break;
			//農家クローン.
		case 1:{
			if(Savetest.kaminoke >= 200 && Savetest.kajitu >= 20 &&
			   Savetest.syokubutu>= 100 ){

			Savetest.kaminoke 		-= 200;
			Savetest.kajitu 		-= 20;
			Savetest.syokubutu    	-= 100;
			 Savetest.clone_amount[1] += 1;
			Application.LoadLevel("MakeEffectScene");
			}
		}break;
			//大工クローン.
		case 2:{
			if(Savetest.kaminoke >= 200 && Savetest.biseibutu >= 40 &&
			   Savetest.tikaranotane>= 10){
			Savetest.kaminoke 		-= 200;
			Savetest.biseibutu 		-= 40;
			Savetest.tikaranotane   -= 10;
			Savetest.clone_amount[2] += 1;
			Application.LoadLevel("MakeEffectScene");
			}
		}break;
			//勇者クローン.
		case 3:{
			if(Savetest.kaminoke >= 800 && Savetest.tikaranotane >= 50 &&
			   Savetest.hosinokakera >= 1){
			Savetest.kaminoke		-= 800;
			Savetest.tikaranotane   -= 50;
			Savetest.hosinokakera   -= 1;
			Savetest.clone_amount[3] += 1;
			Application.LoadLevel("MakeEffectScene");
			}
		}break;
			//船乗りクローン.
		case 4:{
			if(Savetest.kaminoke >= 400    && Savetest.biseibutu >= 100 &&
			   Savetest.tikaranotane  >= 5 && Savetest.tetukuzu  >= -5  &&
			   Savetest.tingyo >= 5){
			Savetest.kaminoke 		-= 400;
			Savetest.biseibutu 	    -= 100;
			Savetest.tikaranotane   -= 5;
			Savetest.tetukuzu 		-= 50;
			Savetest.tingyo 		-= 5;
			Savetest.clone_amount[4] += 1;
			Application.LoadLevel("MakeEffectScene");
			}
		}break;
			//セールスmanクローン.
		case 5:{
			if(Savetest.kaminoke >= 200  && Savetest.syokubutu >= 100 &&
			   Savetest.kajitu >= 100    && Savetest.biseibutu >= 100 && 
			   Savetest.tikaranotane >=5 && Savetest.tingyo >= 10){
			Savetest.kaminoke 		-= 200;
			Savetest.syokubutu 		-= 100;
			Savetest.kajitu 		-= 100;
			Savetest.biseibutu 		-= 100;
			Savetest.tikaranotane 	-= 5;
			Savetest.tingyo 		-= 10;
			Savetest.clone_amount[5] += 1;
			Application.LoadLevel("MakeEffectScene");
			}
		}break;
			//執事クローン.
		case 6:{
			if(Savetest.kaminoke >= 200 && Savetest.biseibutu >= 300 &&
			   Savetest.tiseinotane >= 200){
			Savetest.kaminoke 		-= 200;
			Savetest.biseibutu 		-= 300;
			Savetest.tiseinotane 	-= 200;
			Savetest.clone_amount[6] += 1;
			Application.LoadLevel("MakeEffectScene");
			}
		}break;
			//作家ノーマルクローン.
		case 7:{
			if(Savetest.kaminoke >= 200 && Savetest.tiseinotane >= 500 &&
			   Savetest.tingyo >= 10    && Savetest.nekutai >= 1){
			Savetest.kaminoke 		-= 200;
			Savetest.tiseinotane 	-= 500;
			Savetest.tingyo 		-= 10;
			Savetest.nekutai 		-= 1;
			Savetest.clone_amount[7] += 1;
			Application.LoadLevel("MakeEffectScene");
			}
		}break;
			//鳥ノーマルクローン.
		case 8:{
			if(Savetest.kaminoke >= 10000 && Savetest.toriniku >= 100){
			Savetest.kaminoke 		-= 10000;
			Savetest.toriniku 		-= 100;
			Savetest.clone_amount[8] += 1;
			Application.LoadLevel("MakeEffectScene");
			}
		}break;
			//女性クローン.
		case 9:{
			if(Savetest.kaminoke >= 10     && Savetest.kajitu >= 500 &&
			   Savetest.tiseinotane >= 500 && Savetest.tingyo >= 100 &&
			   Savetest.feromon >= 100){
			Savetest.kaminoke    	-= 10;
			Savetest.kajitu 	 	-= 500;
			Savetest.tiseinotane 	-= 500;
			Savetest.tingyo  	 	-= 100;
			Savetest.feromon 	 	-= 100;
			Savetest.clone_amount[9] += 1;
			Application.LoadLevel("MakeEffectScene");
			}
		} break;
		case 10:{
			if(Savetest.kaminoke >= 200 && Savetest.hosi >= 10){
			//superSTARクローン.
			Savetest.kaminoke 		-= 200;
			Savetest.hosi  		    -= 10;
			Savetest.clone_amount[10] += 1;
			Application.LoadLevel("MakeEffectScene");
			}
		}break;
		default:{
			Debug.Log("CloneData.error!");	
		}break;
		}

	}

	public void CloneName(){
		clonesName [0] = "ノーマルクローン";
		clonesName [1] = "農家オレット";
		clonesName [2] = "大工さん";
		clonesName [3] = "勇者オレット！";
		clonesName [4] = "ふなのり";
		clonesName [5] = "商業マン";
		clonesName [6] = "執事オレット";
		clonesName [7] = "素敵な作家";
		clonesName [8] = "鳥…？";
		clonesName [9] = "女の子";
	}

	public void SyojiImport(){
	//caracter change to strings.
	Syoji.kaminoke     = Savetest.kaminoke.ToString();
	Syoji.syokubutu    = Savetest.syokubutu.ToString();
	Syoji.kajitu       = Savetest.kajitu.ToString();
    Syoji.biseibutu    = Savetest.biseibutu.ToString();
	Syoji.tikaranotan  = Savetest.tikaranotane.ToString();
	Syoji.hosinokakera = Savetest.hosinokakera.ToString();
	Syoji.tetukuzu     = Savetest.tetukuzu.ToString();
	Syoji.tingyo       = Savetest.tingyo.ToString();
	Syoji.tiseinotane  = Savetest.tiseinotane.ToString();
	Syoji.nekutai      = Savetest.nekutai.ToString();
	Syoji.toriniku     = Savetest.toriniku.ToString();
	Syoji.feromon      = Savetest.feromon.ToString();
	Syoji.hosi         = Savetest.hosi.ToString();

	
	
	}
}
