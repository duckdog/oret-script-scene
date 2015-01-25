using UnityEngine;
using System.Collections;

public class BUTURITEST : MonoBehaviour {

	public GameObject cubeprefabs = null;
	private GameObject[] cubes = new GameObject[10];
	// Use this for initialization
	void Start () {

		for (int i = 0; i < 10; i++) {
		 cubes [i] = Instantiate (cubeprefabs) as GameObject;
			cubes[i].transform.position = this.transform.localPosition;
			cubes[i].transform.position 
				+= new Vector3(Mathf.Sin(18 * i) * 20,0.0f,Mathf.Cos(18 * i) * 20);
		}
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Player")
			GameObject.Destroy(this.gameObject);
	}
}
