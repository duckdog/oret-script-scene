using UnityEngine;
using System.Collections;

public class Sailoranimation : MonoBehaviour {
	private Animator animators;
	private int JumpId;
	private bool fall;
	// Use this for initialization
	void Start () {
		animators = GetComponent<Animator>();
		JumpId = Animator.StringToHash("Do Jump");
		animators.SetBool (JumpId,false);
	}
	
	// Update is called once per frame
	void Update () {
	   if (Input.GetMouseButtonDown(0)) {
			this.transform.Translate(Vector3.up * 50 * Time.deltaTime);
						fall = true;
						animators.SetBool (JumpId,true);
				}
		if(fall){
			this.transform.Translate(Vector3.up * 1 * Time.deltaTime);
			this.transform.Translate(Vector3.forward * 1 * Time.deltaTime);
			this.transform.Translate(Vector3.down    * 3 * Time.deltaTime);
		}
	}
}
