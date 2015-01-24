using UnityEngine;
using System.Collections;

public class shotcollider : MonoBehaviour {
	public static int  amount;
	// Use this for initialization
	void Start () {
		amount = 0;
	}
	void OnTriggerStay(Collider other){
		if (other.gameObject.tag == "Enemy") {
			//Debug.Log("hithithit!");
			GameObject.Destroy(this.gameObject);
			GameObject.Destroy(other.gameObject);
			PilotText.amount += 1;
		}
	
	}
	// Update is called once per frame
	void Update () {
	
	}
}
