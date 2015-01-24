using UnityEngine;
using System.Collections;

public class ItemGet : MonoBehaviour {
	public GameObject foundmark;
	private GameObject foundprefab;
	private int on = 0;



	void OnCollisionStay(Collision other){

		if (other.gameObject.tag == "Home") {
			Application.LoadLevel ("MakeClone");
		}


		if (other.gameObject.tag == "Item") {
			if (on == 0)
				foundprefab = Instantiate (foundmark) as GameObject;
			on = 1; 
			var pos = transform.position;
			foundmark.transform.position
				= new Vector3(this.transform.position.x,2.0f,this.transform.position.z);
		} 
		else {
			on = 0;
			Destroy(foundprefab.gameObject);
		}

	}




	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
