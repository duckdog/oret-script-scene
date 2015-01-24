using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {

	private Vector3      pos;
	private Vector3      angle;
	public GameObject    bulletprefab;
	private GameObject[] bullets  = new GameObject[50];
	private float[]      lifetime = new float[50];
	private float time_lag;
	// Use this for initialization
	void Start () {
		time_lag = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		pos   = this.transform.position;
		if(!pilotControl.stop)
		Shotflag ();
		BulletsMoving ();
		Bulletlifetime ();
	}

	void Shotflag(){
		//shot
		if (Input.GetMouseButton(0)) {
			for(int i = 0;i < 50; i++){
				if(bullets[i] == null && time_lag <= 0){
					time_lag = 1.0f;
					lifetime[i] = 1.0f;
				    bullets[i] 
				       = GameObject.Instantiate(this.bulletprefab) as GameObject;
				    bullets[i].transform.position = (pos);
					bullets[i].transform.localRotation = GameObject.Find("p47_scheme1").transform.localRotation;
				}
			}
		}

		//shot lag
		if (time_lag > 0.0f) {
			Debug.Log (time_lag+" timelag");
			time_lag -= 10.0f * Time.deltaTime;		
		}
	}

	//bullet Speed processing
	void BulletsMoving(){
		for(int i = 0;i < 50; i++){
			if(bullets[i] == null) continue;
			
			bullets[i].transform.Translate(Vector3.down * (300 +pilotControl.speed) * Time.deltaTime);
		}
	}

	void Bulletlifetime(){
		for (int i = 0; i < 50; i++) {
			if(bullets[i] == null) continue;
			lifetime[i] -= 0.5f * Time.deltaTime;

			if(lifetime[i] <= 0)  GameObject.Destroy(bullets[i]);//(bullets[i]);
		}
	}


	void OnCollisionEnter(Collision other){

		if (other.gameObject.tag == "Enemy") {
				GameObject.Destroy(this);
				GameObject.Destroy(other.gameObject);
		}
		if (other.gameObject.tag == "Terrain"){

			GameObject.Destroy(this);

		}
	}
}
