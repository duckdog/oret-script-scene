using UnityEngine;
using System.Collections;

public class MoveMacine : MonoBehaviour {
	public float time;
	public bool leftdoor = false;
	public bool rightdoor = false;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (time < 7)
			time += 1 * Time.deltaTime;
		else
			Clone.open = true;
		
				{
						if (time < 3.0  && !leftdoor && !rightdoor)
								this.transform.localScale = new Vector3 (33 + Mathf.Sin (2.0f * Time.deltaTime) * 30,
		                                        4.0f, 12.878f);

						if (time >= 3.0  && time < 7 && leftdoor)
								this.transform.Translate (Vector3.left * 2.5f * Time.deltaTime);
						if (time >= 3.0  && time < 7 && rightdoor)
								this.transform.Translate (Vector3.right * 2.5f * Time.deltaTime);
				} 
	}
}
