using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {
	private Animator animator;
	private int doWalkId;

	private struct Key{
		public bool up;
		public bool down;
		public bool right;
		public bool left;
		public bool pick;
		public bool action;
	}
	
	private Key key;
	private void get_input(){
		this.key.up = false;
		this.key.down = false;
		this.key.right = false;
		this.key.left = false;
		
		//
		this.key.up |= Input.GetKey (KeyCode.W);
		this.key.up |= Input.GetKey (KeyCode.Keypad8);
		
		this.key.down |= Input.GetKey (KeyCode.S);
		this.key.down |= Input.GetKey (KeyCode.Keypad2);
		
		this.key.right |= Input.GetKey (KeyCode.D);
		this.key.right |= Input.GetKey (KeyCode.Keypad6);
		
		this.key.left |= Input.GetKey (KeyCode.A);
		this.key.left |= Input.GetKey (KeyCode.Keypad4);
		
		
	}

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		doWalkId = Animator.StringToHash("Do walk");
	}
	
	// Update is called once per frame
	void Update () {
		this.get_input ();
		if (this.key.up ||this.key.down||this.key.left||this.key.right ||
		    Title.continueplay || Title.firstplay) {
			animator.SetBool (doWalkId, true);
		} else {
			animator.SetBool(doWalkId,false);		
		}
	
	}
}
