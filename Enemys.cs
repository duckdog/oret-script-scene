using UnityEngine;
using System.Collections;

public class Enemys : MonoBehaviour {
	public  GameObject   enemyprefab;
	private GameObject[] enemys = new GameObject[300];

	// Use this for initialization
	void Start () {
		Arrangement ();
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0; i < 300; i++){
		enemys[i].transform.Translate
				(new Vector3(-Mathf.PI * Time.deltaTime,Mathf.PI * Time.deltaTime,0.0f));
		}
	}
	void Arrangement(){
		for(int i = 0; i < 300; i++){
	   	 enemys[i] = GameObject.Instantiate(enemyprefab) as GameObject;
		 enemys[i].transform.position =
				(new Vector3(Random.Range(500, 7500),Random.Range(10, 300),Random.Range(500,3500)));
		enemys[i].transform.Rotate
				(Random.Range(0,180),Random.Range(0,180),Random.Range(0,180));
		enemys[i].tag = "Enemy";

		}
	}



}
