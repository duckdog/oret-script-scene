using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
	Vector3 frontpos;
	Vector3 backpos;
	Vector3 leftpos;
	Vector3 rightpos;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		frontpos = new Vector3 (0.0f,0.0f,0.0f);
		backpos =  new Vector3 (0.0f,180.0f,0.0f);
		leftpos =  new Vector3 (0.0f,90.0f,0.0f);
		rightpos = new Vector3 (0.0f,270.0f,0.0f);
		//ホウコウキーでオブジェクトを動かす（↑）.
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			this.transform.Rotate(
				frontpos);
		}
		//ホウコウキーでオブジェクトをうごかす（↓）.
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			this.transform.Rotate (
				backpos);
		}
		//ホウコウキーでオブジェクトを動かす（↑）.
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			this.transform.Rotate(
				leftpos);
		}
		//ホウコウキーでオブジェクトをうごかす（↓）.
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			this.transform.Rotate (
				rightpos);
	}
}
}
