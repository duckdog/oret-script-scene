using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {
	public Texture buttonTexture;
	public Texture2D designdate = null;

	bool Opendata = false;
	bool Openmaterial = false;
	bool madeclone = false;
	public GameObject prefab = null;//クローンのprefab倉庫.
	public GameObject clone = null;

	public  Vector3 charapos = new Vector3 (-1.29f,1.84f,4.86f); //しるえっとのぽししょん.
	public  Rect  yajirusi_R = new  Rect (Screen.width/2,Screen.height/2,100,100);
	public  Rect  yajirusi_L = new  Rect (50,180,50,50);
	void start(){

	}

	 public void OnGUI(){
	
		//クローン作成画面に移行.
		if (!Opendata && ! Openmaterial && GUI.Button (new Rect (20, 20, 130, 50), "クローンをつくる")){
			Opendata = true;
		}
		//シルエットを一度だけさくせい.
		if (Opendata && !madeclone) {
			//作成するクローンのシルエットを表示.
			clone = Instantiate(prefab) as GameObject;
			clone.transform.position = (charapos);
			madeclone = true;
			
		}
		//ボタンがおされたらクローン必要素材を表示.
		if (Opendata) {

			GUI.DrawTexture (new Rect(20,64,300,300),designdate);
			//クローンの粗材データを呼び出す.
			this.gameObject.GetComponent<CloneDate> ().OnGUI(Opendata);
			//キャラをまわす.
			clone.transform.Rotate(0.0f,0.0f,20 * Time.deltaTime);
			//作成ボタンを表示.
			if(GUI.Button(new Rect(Screen.width - 100,300,100,100),"作成っ!!")){
				Application.LoadLevel("MakeEffectScene");
			}
			//矢印表示　次のキャラクターデータへ.
			if(GUI.Button (yajirusi_R,"⇒")){
				CloneDate.number += 1;
				if(CloneDate.number >= 2) CloneDate.number = 0;
			}
			if(GUI.Button (yajirusi_L,"⇐")){
				CloneDate.number -= 1;
				if(CloneDate.number < 0) CloneDate.number = 1;
			}


			//戻る画面を表示.
			if (GUI.Button (new Rect (20, 20, 100, 50), "戻る")){
				Opendata = false;
				Destroy(clone);
				madeclone = false;
			}
		}

		//アイテム確認画面.
		if(!Opendata && !Openmaterial && GUI.Button (new Rect(20,20 + 60,130, 50),"アイテムを確認")){
			Openmaterial = true;
		}
		//戻る画面を表示.
		if (Openmaterial && GUI.Button (new Rect (20, 20 + 60, 130, 50), "戻る")){
			Openmaterial = false;
		}
	}

	public void CloseData(){
		//戻る画面を表示.
		Opendata = false;
		Destroy(clone);
		madeclone = false;

	}
	public void OpenData(){
		if(!Opendata)
		Opendata = true;

		//シルエットを一度だけさくせい.
		if (Opendata && !madeclone) {
			//作成するクローンのシルエットを表示.
			clone = Instantiate(prefab) as GameObject;
			clone.transform.position = (charapos);
			madeclone = true;
			
		}
		//ボタンがおされたらクローン必要素材を表示.
		 {
			
			GUI.DrawTexture (new Rect(20,64,300,300),designdate);
			//クローンの粗材データを呼び出す.
			this.gameObject.GetComponent<CloneDate> ().OnGUI(Opendata);
			//キャラをまわす.
			clone.transform.Rotate(0.0f,0.0f,20 * Time.deltaTime);
			//作成ボタンを表示.
			if(GUI.Button(new Rect(Screen.width - 100,300,100,100),"作成っ!!")){
				Application.LoadLevel("MakeEffectScene");
			}
		}

	}
}



