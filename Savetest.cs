using UnityEngine;
using System.Collections;


public class Savetest : MonoBehaviour {

	//アイテム所持数保存変数　変数名はゲーム内の素材の名と同じに.
	public static int kaminoke;
	public static int syokubutu;
	public static int kajitu;
	public static int biseibutu;
	public static int tikaranotane;
	public static int hosinokakera;
	public static int tetukuzu;
	public static int tingyo;
	public static int tiseinotane;
	public static int nekutai;
	public static int toriniku;
	public static int feromon;
	public static int hosi;

	public static int money;

	public static int[] clone_amount = new int[10];



	//int kaminoke = 0;
	
	void Awake () {
	
		kaminoke       = PlayerPrefs.GetInt("kaminoke");
		kajitu         = PlayerPrefs.GetInt("kajitu");
		syokubutu      = PlayerPrefs.GetInt("syokubutu");
		biseibutu      = PlayerPrefs.GetInt ("biseibutu");
		tikaranotane   = PlayerPrefs.GetInt("tikaranotane");
		hosinokakera   = PlayerPrefs.GetInt("hosinokakera"); 
		tetukuzu       = PlayerPrefs.GetInt("tetukuzu");
		tingyo         = PlayerPrefs.GetInt("tingyo");
		tiseinotane    = PlayerPrefs.GetInt("tiseinotane");
		nekutai        = PlayerPrefs.GetInt("nekutai");
		toriniku       = PlayerPrefs.GetInt("toriniku");
		feromon        = PlayerPrefs.GetInt("feromon");
		hosi           = PlayerPrefs.GetInt("hosi");
		money          = PlayerPrefs.GetInt("money");

		for (int i = 0; i < 10; i++) {
			clone_amount[i] = PlayerPrefs.GetInt("clone" + i.ToString());	
		}
   }
	public void Delete(){
		PlayerPrefs.DeleteKey("kaminoke");
		PlayerPrefs.DeleteKey("kajitu");
		PlayerPrefs.DeleteKey("syokubutu");
		PlayerPrefs.DeleteKey("biseibutu");
		PlayerPrefs.DeleteKey("tikaranotane");
		PlayerPrefs.DeleteKey("hosinokakera"); 
		PlayerPrefs.DeleteKey("tetukuzu");
		PlayerPrefs.DeleteKey("tingyo");
		PlayerPrefs.DeleteKey("tiseinotane");
		PlayerPrefs.DeleteKey("nekutai");
		PlayerPrefs.DeleteKey("toriniku");
		PlayerPrefs.DeleteKey("feromon");
		PlayerPrefs.DeleteKey("hosi");
		PlayerPrefs.DeleteKey("money");

		for (int i = 0; i < 10; i++) {
		PlayerPrefs.DeleteKey("clone" + i.ToString());	
		}
	}

	void OnGUI () {
//		if (GUI.Button(new Rect(5, 5, 200, 50), "+1")) {
//			kaminoke++;
//		kaminoke = 1000;
//		money = 5000;
//		kajitu   = 10000;
//		syokubutu      = 10000;
//		biseibutu      = 10000;
//		tikaranotane   = 10000;
//		hosinokakera   =10000; 
//		tetukuzu       = 10000;
//		tingyo         =10000;
//		tiseinotane    =10000;
//		nekutai        =10000;
//		toriniku       =10000;
//		feromon        =10000;
//		hosi           =10000;


		PlayerPrefs.SetInt("syokubutu",syokubutu);
		PlayerPrefs.SetInt ("biseibutu",biseibutu);
		PlayerPrefs.SetInt("tikaranotane",tikaranotane);
		PlayerPrefs.SetInt("hosinokakera",hosinokakera); 
		PlayerPrefs.SetInt("tetukuzu",tetukuzu);
		PlayerPrefs.SetInt("tingyo",tingyo);
		PlayerPrefs.SetInt("tiseinotane",tiseinotane);
		PlayerPrefs.SetInt("nekutai",nekutai);
		PlayerPrefs.SetInt("toriniku",toriniku);
		PlayerPrefs.SetInt("feromon",feromon);
		PlayerPrefs.SetInt("hosi",hosi);
		PlayerPrefs.SetInt("kaminoke", kaminoke);//Save.
		PlayerPrefs.SetInt("kajitu", kajitu);
		PlayerPrefs.SetInt ("money", money);

		for (int i = 0; i < 10; i++) {
			PlayerPrefs.SetInt("clone" + i.ToString(),clone_amount[i]);	
		}
//		}
//		if (GUI.Button(new Rect(5, 60, 200, 50), "Data Clear")) {
//			kaminoke = 0;
//			PlayerPrefs.DeleteKey("kaminoke");//消去.
//		}
//		GUI.Label(new Rect(5, Screen.height-20, Screen.width-10, 50), "kaminoke:"+kaminoke);
	}
	// Use this for initialization
	void Start () {
	
	}



	// Update is called once per frame
	void Update () {

	}
}
