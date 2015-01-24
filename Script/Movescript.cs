using UnityEngine;
using System.Collections;

public class Movescript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//cubescriptのメソッドをよびだす(オブジェクトのサイズを変更).
		if (Input.GetKey (KeyCode.G)) {
			GameObject go = GameObject.Find ("Cube") as GameObject;
			//go.GetComponent<Cubescript>().Bigsize();
		}


		//ホウコウキーでオブジェクトを動かす（↑）.
		if (Input.GetKey (KeyCode.UpArrow)) {
			this.transform.Translate(
				new Vector3(0.0f,0.0f,5.0f * Time.deltaTime));
		}
		//ホウコウキーでオブジェクトをうごかす（↓）.
		if (Input.GetKey (KeyCode.DownArrow)) {
			this.transform.Translate (
				(Vector3.back * 5.0f * Time.deltaTime));
		}
		//ホウコウキーでオブジェクトを動かす（↑）.
		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.Translate(
				Vector3.left * 5.0f * Time.deltaTime);
		}
		//ホウコウキーでオブジェクトをうごかす（↓）.
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.Translate (
				(Vector3.right * 5.0f * Time.deltaTime));
		}
		//Cubeをcapsuleの親関係としてつなぐ
		if (Input.GetKey (KeyCode.P)) {
			GameObject go = GameObject.Find ("Cube") as GameObject;
			go.transform.parent = this.transform;
		}
		//Cubeとcapsuleの親関係をはなす
		if (Input.GetKey (KeyCode.N)) {
			GameObject go = GameObject.Find ("Cube") as GameObject;
			go.transform.parent = null;


				}

	}
}
