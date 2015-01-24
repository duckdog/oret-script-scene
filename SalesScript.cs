using UnityEngine;
using System.Collections;

public class SalesScript : MonoBehaviour {
	GameObject test;

	void OnTriggerStay(Collider other){
				if (other.gameObject.tag == "Player") {

				}
		}
	// Use this for initialization
	void Start () {
		test = GameObject.Find("Button") as GameObject;
		test.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
