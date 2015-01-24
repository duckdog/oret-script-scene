using UnityEngine;
using System.Collections;

public class Clone : MonoBehaviour {
	
	public GameObject[] prefabs;
	private GameObject cloneobject = null;
	public Vector3 pos;
	public Vector3 size;
	public Rect namepos;
	public GUIStyle style;
	public static bool open  = false;

	// Use this for initialization
	void Start () {
		style.normal.textColor = Color.white;
		style.fontSize = 30;
		pos = new Vector3(12.7f,0.5f,-6.1f);
		namepos = new Rect (Screen.width / 2 - 100.0f, 200.0f, 100.0f, 100.0f);
		cloneobject = Instantiate (prefabs [CloneDate.number]) as GameObject;
		cloneobject.transform.Translate (pos);
		cloneobject.transform.Rotate(0.0f, 180f, 0.0f);
		cloneobject.transform.localScale = new Vector3(15.0f, 15.0f, 15.0f);
		Debug.Log (CloneDate.number);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
	if (open) {
		switch (CloneDate.number) {
			case 0:
				GUI.Label (namepos, "ノーマルクローン",style);
				break;
			case 1:
				GUI.Label (namepos, "農家オレット",style);
				break;
			case 2:
				GUI.Label (namepos, "大工オレット",style);
				break;
			case 3:
				GUI.Label (namepos, "勇者！オレット",style);
				break;
			case 4:
				GUI.Label (namepos, "船乗りオレット",style);
				break;
			case 5:
				GUI.Label (namepos, "工業マン",style);
				break;
			case 6:
				GUI.Label (namepos, "執事オレット",style);
				break;
			case 7:
				GUI.Label (namepos, "作家オレット",style);
				break;
			case 8:
				GUI.Label (namepos, "鳥？オレット",style);
				break;
			case 9:
				GUI.Label (namepos, "オレットちゃん？",style);
				break;
			case 10:
				GUI.Label (namepos, "スーパースター！",style);
				break;
			case 11:
				GUI.Label (namepos, "ノーマルクローン",style);
				break;
			case 12:
				GUI.Label (namepos, "ノーマルクローン",style);
				break;
				
				
			}
				}
	
	}
}
