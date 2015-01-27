using UnityEngine;
using System.Collections;

public class Playercontrol2 : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey (KeyCode.W))
			this.transform.Translate (Vector3.forward * speed* Time.deltaTime);
		if (Input.GetKey (KeyCode.D)){
			this.transform.Rotate(new Vector3(0.0f, speed* 2  * Time.deltaTime,0.0f));
			this.transform.Translate (Vector3.forward * speed/5* Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.A)){
			this.transform.Rotate(new Vector3(0.0f, -speed * 2* Time.deltaTime,0.0f));
			this.transform.Translate (Vector3.forward * speed/5* Time.deltaTime);
		}
	}
}
