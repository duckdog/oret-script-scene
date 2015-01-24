using UnityEngine;
using System.Collections;

public class ItemDrop : MonoBehaviour {
	private float  MapMAX_X;
	private float  MapMAX_Z;

	private int Item_MAX = 10;
	public GameObject[] Itemprefab ;
	public GameObject[] Iteminfo;

	public GameObject foundsilhouette;

	public static bool getscreen;
	private Rect textpos;
	public static int number; 
	public static int amount; 
	public static float time;

//	public static int kaminoke;
//	public static int syokubutu;
//	public static int kajitu;
//	public static int biseibutu;
	// Use this for initialization
	void Start () {

		number = 0;
		time = 0.0f;
		textpos = new Rect (Screen.width/2, Screen.height/2, 200, 100);
		for (int i = 0; i < Item_MAX; i++){
			Iteminfo[i] = 
				GameObject.Instantiate(this.Itemprefab[i]) as GameObject;

			Iteminfo[i].transform.position =
				new Vector3(Random.Range(16.0f,70.0f),0.01f,Random.Range(20.0f,80.0f));
		}
	}

	void OnCollisionStay(Collision other){
		if (other.gameObject.tag == "Player") {

			if(Input.GetMouseButtonDown(0)){
				//アイテムをランダムで取得.
				number = Random.Range(0,3);
				//アイテム取得、数も乱数にて取得.
				switch(number){
				case 0:{

					amount = Random.Range(3,10);
					Savetest.kajitu += amount;
					getscreen = true;
					Debug.Log (getscreen+"果実："+Savetest.kajitu+"\n 植物:" 
					           + Savetest.syokubutu +
					           "\n微生物："+ Savetest.biseibutu);
				}
					break;
				case 1:{
					amount = Random.Range(3,10);
					Savetest.biseibutu += amount;
					getscreen = true;
					Debug.Log (getscreen+"果実："+Savetest.kajitu+"\n 植物:" 
					           + Savetest.syokubutu +
					           "\n微生物："+ Savetest.biseibutu);
				}
					break;
				case 2:{
					amount = Random.Range(3,10);
					Savetest.syokubutu+= amount;
					getscreen = true;
					Debug.Log (getscreen+"果実："+Savetest.kajitu+"\n 植物:" 
					           + Savetest.syokubutu +
					           "\n微生物："+ Savetest.biseibutu);
				}
					break;
				}
				//きらきらを消去.
				Destroy(this.gameObject);
			}		
		}
	}

	private void OnGUI(){
				if (getscreen && time <= 60) {
						time += 1 * Time.deltaTime;
						switch (number) {
						case 0:
								GUI.Label (textpos, "謎の果実を" + amount + "個手に入れた。");
								break;
						case 1:
								GUI.Label (textpos, "謎の微生物を" + amount + "体捕まえた。");
								break;
						case 2:
								GUI.Label (textpos, "謎の植物を" + amount + "個手に入れた。");
								break;
						}
				}
				else {
					getscreen =false;
					time = 0.0f;
				}
	}
	// Update is called once per frame
	void Update () {


	}
}
