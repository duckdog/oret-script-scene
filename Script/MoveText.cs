using UnityEngine;
using System.Collections;

public class MoveText : MonoBehaviour {
	public   bool down = false;
	public   bool left = false; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(left)
		this.transform.Translate (Vector3.right * 20.0f * Time.deltaTime);
		if(down)
			this.transform.Translate (Vector3.down * 20.0f * Time.deltaTime);
	
	}
}
