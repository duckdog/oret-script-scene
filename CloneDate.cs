using UnityEngine;
using System.Collections;

public class CloneDate: MonoBehaviour {
	ButtonScript button;
	public static int number = 0;

	public Rect namepos = new Rect(150,200,300,300);
	public struct Name{ 
	public static string kaminoke  	      = "オレットの髪の毛";
	public static string kajitu   	      = "謎の果実";
	public static string biseibutu   	  = "謎の微生物";
	public static string syokubutu  	      = "謎の植物";
	public static string tikaranotane     = "力の種";
	public static string hosinokakera     = "星のカケラ";
	public static string tetukuzu   	  = "鉄くず";
	public static string tingyo     	  = "チンギョ";
	public static string tiseinotane   	  = "知性の種";
	public static string nekutai    	  = "素敵な蝶ネクタイ";
	public static string toriniku    	  = "鶏肉";
	public static string feromon    	  = "謎のフェロモン";
    public static string hosi       	  = "星石";

	}
	
	private GUIStyle style;//色変更用.
	public GUISkin guiSkin;//font 変更.

	public static Rect sozaiPos;
	public static Rect sozaiPos2;
	public static Rect sozaiPos3;
	public static Rect syojiPos;
	public static Rect syojiPos2;
	public static Rect syojiPos3;
	Savetest savetest;



//	public void Need(){
//		//ノーマルクローン.
//
//		switch(TextTest.currentLine){
//		case 0:{
//		Savetest.kaminoke 		-= 200;
//		}break;
//		//農家クローン.
//		case 1:{
//		Savetest.kaminoke 		-= 200;
//		Savetest.kajitu 		-= 20;
//		Savetest.syokubutu    	-= 100;
//		}break;
//		//大工クローン.
//		case 2:{
//		Savetest.kaminoke 		-= 200;
//		Savetest.biseibutu 		-= 40;
//		Savetest.tikaranotane   -= 10;
//		}break;
//		//勇者クローン.
//		case 3:{
//		Savetest.kaminoke		-= 800;
//		Savetest.tikaranotane   -= 50;
//		Savetest.hosinokakera   -= 1;
//		}break;
//		//船乗りクローン.
//		case 4:{
//		Savetest.kaminoke 		-= 400;
//		Savetest.biseibutu 	    -= 100;
//		Savetest.tikaranotane   -= 5;
//		Savetest.tetukuzu 		-= 50;
//		Savetest.tingyo 		-= 5;
//		}break;
//		//セールスmanクローン.
//		case 5:{
//		Savetest.kaminoke 		-= 200;
//		Savetest.syokubutu 		-= 100;
//		Savetest.kajitu 		-= 100;
//		Savetest.biseibutu 		-= 100;
//		Savetest.tikaranotane 	-= 5;
//		Savetest.tingyo 		-= 10;
//		}break;
//		//執事クローン.
//		case 6:{
//		Savetest.kaminoke 		-= 200;
//		Savetest.biseibutu 		-= 300;
//		Savetest.tiseinotane 	-= 200;
//		}break;
//		//作家ノーマルクローン.
//		case 7:{
//	    Savetest.kaminoke 		-= 200;
//		Savetest.tiseinotane 	-= 500;
//		Savetest.tingyo 		-= 10;
//		Savetest.nekutai 		-= 1;
//		}break;
//		//鳥ノーマルクローン.
//		case 8:{
//		Savetest.kaminoke 		-= 10000;
//		Savetest.toriniku 		-= 100;
//		}break;
//		//女性クローン.
//		case 9:{
//		Savetest.kaminoke    	-= 10;
//		Savetest.kajitu 	 	-= 500;
//		Savetest.tiseinotane 	-= 500;
//		Savetest.tingyo  	 	-= 100;
//		Savetest.feromon 	 	-= 100;
//		} break;
//		case 10:{
//		//superSTARクローン.
//		Savetest.kaminoke 		-= 200;
//		Savetest.hosi  		    -= 10;
//		}
//		default:{
//		Debug.de	
//		}break;
//	   }
//	}

	// Use this for initialization
	void Start () {
		style = new GUIStyle();
		style.fontSize = 30;


		sozaiPos = new Rect (Screen.width/2+ 250,Screen.height/2,500,500);
		sozaiPos2 = new Rect (Screen.width/2+ 250,Screen.height/2 + 30,500,500);
		sozaiPos3 = new Rect (Screen.width/2+ 250,Screen.height/2 + 60,500,500);
		syojiPos = new Rect (Screen.width/2 + 700,Screen.height/2,500,500);
		syojiPos2 = new Rect (Screen.width/2 + 700,Screen.height/2 + 30,500,500);
		syojiPos3 = new Rect (Screen.width/2 + 700,Screen.height/2 + 60,500,500);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnGUI(bool Opendata){
		//数字をTostringで文字に変更.
			//string syoji_kaminoke= Savetest.kaminoke.ToString();
			//string syoji_kajitu= Savetest.kajitu.ToString();

		//できるクローンの種類.
//		switch(number){
//		case 0://ノーマルクローン
//		{
//			GUI.Label (namepos,"ノーマルクローン",style);
//		
//			GUI.Label (new Rect(5,Screen.height - 150,10,50),"初まりはここから\n自分のクローンの成果第一号を今。",style);
//
//			//必要素材の名前を表示.
//			GUI.Label(sozaiPos,Name.kaminoke + kaminoke_amount + "個",style);
//
//			//数字をTostringで文字に変更.
//			string syoji = Savetest.kaminoke.ToString();
//			//現在の素材所持数を表示.
//			GUI.Label (syojiPos,syoji_kaminoke +"個",style);
//		}
//			break;
//		case 1://農家オレット.
//		{
//			GUI.Label (namepos,"農家オレット",style);
//			
//			GUI.Label (new Rect(5,Screen.height - 150,10,50),"何故これができたのかは不明.\n" +
//				"「何が得意そう？」と聞いたところ「…農業？」\nと、そこでやっと判明。幼少期夢見た職業の一つ",style);
//			
//			//必要素材の名前を表示.
//			GUI.Label(sozaiPos,Name.kaminoke + kaminoke_amount + "個",style);
//			GUI.Label(sozaiPos2,Name.kajitu  + kajitu_amount   + "個",style);
//			//現在の素材所持数を表示.
//			GUI.Label (syojiPos,syoji_kaminoke + "個",style);
//			GUI.Label (syojiPos2,syoji_kajitu + "個",style);
//			
//
//		}
//			break;
//		}

	}
}
