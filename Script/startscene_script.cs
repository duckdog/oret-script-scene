using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class startscene_script : MonoBehaviour {
	public Text Day;
	// Use this for initialization
	void Start () {
		Savetest.day += 1;
		Day.text += Savetest.day.ToString() + "日目";
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetMouseButton (0) || Input.GetMouseButton (1)) {
			Application.LoadLevel("MakeClone");		
		}
	}
}
