//using UnityEngine;
//using System.Collections;
//using System.Collections.Generic;
//
////しょじしている素材を保存するばしょ.
//public class LevelData{
//
//	public bool kaminoke_on;
//	public int kaminoke;
//
//	public bool syokubutu_on;
//	public int  syokubutu;
//	
//	public bool biseibutu_on;
//	public int  biseibutu;
//
//	public bool kajitu_on;
//	public int  kajitu;
//}
//public class LevelControl : MonoBehaviour {
//	private List<LevelData> level_datas = new List<LevelData>();//コンストラクタ.
//	// Use this for initialization
//
//	public void LoadLevelData(TextAsset level_data_text){
//				//テキストデータを,文字列として取り込む.
//				string level_texts = level_data_text.text;
//				//改行コード’\’ごとに分割し,文字列の配列にいれる.
//				string[] lines = level_texts.Split ('\n');
//
//				int n = 0;
//				//lines内の各行にたいして、順番に処理していくループ.
//				foreach (var line in lines) {
//						if (line == "") {
//								continue;
//						}
//				
//						Debug.Log (line);
//						string[] words = lines.Split ();
//					
//						
//						//LevelDataの変数を作成.
//						LevelData level_data = new LevelData ();
//
//						foreach (var word in words) {
//								if (word.StartsWith ("#"))
//										break;
//								if (word == "")
//										continue;
//
//
//			
//
//								switch (n) {
//					case 0:
//					level_data.kaminoke_on = int.Parse (word);
//					break;
//				case 1:
//					level_data.kaminoke = int.Parse (word);
//					break;
//				case 2:
//					level_data.kaminoke = int.Parse (word);
//					break;
//				case 3:
//					level_data.kaminoke = int.Parse (word);
//					break;
//				case 4:
//					level_data.kaminoke = int.Parse (word);
//					break;
//				case 5:
//					level_data.kaminoke = int.Parse (word);
//					break;
//
//				}
//						}
//				}
//		}
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}
//}
