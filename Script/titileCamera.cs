using UnityEngine;
using System.Collections;

public class titileCamera : MonoBehaviour {
	public bool zrototate = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!zrototate)
		this.transform.Rotate(Vector3.up * Time.deltaTime);
		if(zrototate)
			this.transform.Rotate(0.0f,0.0f,1 * Time.deltaTime);

	}
}
