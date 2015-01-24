using UnityEngine;
using System.Collections;

public class pilotControl : MonoBehaviour {

	private float MaxSpeed = 300;
	public static float speed;
	public static bool stop;
	public static float  count; 
	// Use this for initialization
	void Start () {
		stop  = true;
		count = 0;
		speed = 50;
	}
	
	// Update is called once per frame
	void Update () {
		if (!stop && count <= 0) {
			this.transform.Translate (Vector3.down * speed * Time.deltaTime);
			this.Contorl ();
		}

	}

	void Contorl(){
		if (Input.GetMouseButton(1)) {
			if(speed < MaxSpeed)
			speed += 20.0f * Time.deltaTime;
			this.transform.Translate(Vector3.down * speed * Time.deltaTime);
		}
		else {
			if(speed >= 50) speed -= 40 * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.A)) {
			this.transform.Rotate(Vector3.down * 100 * Time.deltaTime);
			this.transform.Translate(Vector3.left * 100 * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D)) {
			this.transform.Rotate(Vector3.up * 100 * Time.deltaTime);
			this.transform.Translate(Vector3.right * 100 * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.W)) {
			this.transform.Rotate(Vector3.left * 100 * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) {
			this.transform.Rotate(Vector3.right * 100 * Time.deltaTime);
		}

			


	}
}
 