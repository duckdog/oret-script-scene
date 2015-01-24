using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public static float MOVE_SPEED = 20.0f;//移動速度.
	public static int Vector = 0;
	private struct Key{
		public bool up;
		public bool down;
		public bool right;
		public bool left;
		public static int vector;
		//public bool pick;
		//public bool action;
	}

	private Key key;

	public enum STEP {
		NONE = -1,
		MOVE = 0,
	};

	public STEP step = STEP.NONE;
	public STEP next_step = STEP.NONE;
	public float step_timer = 0.0f;

	// Use this for initialization
	void Start () {
		this.step = STEP.NONE;
		this.next_step = STEP.MOVE;
		Key.vector = 0;
	}

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

		if (Input.GetMouseButtonDown(1)) {
						switch (Key.vector) {
						case 0:
								{
										if (this.key.up)
												Key.vector = 0;
										if (this.key.right)
												Key.vector = 3;
										if (this.key.down)
												Key.vector = 2;
										if (this.key.left)
												Key.vector = 1;
								}
								break;
						case 1:
								{
										if (this.key.up)
												Key.vector = 1;
										if (this.key.right)
												Key.vector = 0;
										if (this.key.down)
												Key.vector = 3;
										if (this.key.left)
												Key.vector = 2;
								}
								break;
						case 2:
								{
										if (this.key.up)
												Key.vector = 2;
										if (this.key.right)
												Key.vector = 1;
										if (this.key.down)
												Key.vector = 0;
										if (this.key.left)
												Key.vector = 3;
								}
								break;
						case 3:
								{
										if (this.key.up)
												Key.vector = 3;
										if (this.key.right)
												Key.vector = 2;
										if (this.key.down)
												Key.vector = 1;
										if (this.key.left)
												Key.vector = 0;
								}
								break;
						}
				}
	}

	private void move_control(){
		Vector3 move_vector = Vector3.zero;//移動用ベクトル.
		Vector3 position = this.transform.position;//現在位置を保管.
		bool is_moved = false;

		if (!PlayerUI.Stop) {
						switch (Key.vector) {
						case 0:
								{//正面を向いてるときの方向.
										if (this.key.right) {
												move_vector += Vector3.right; //移動用ベクトルを右に向ける.
												is_moved = true;			//移動中フラグをたてる.
										}

										if (this.key.left) {
												move_vector += Vector3.left;
												is_moved = true;
										}
										if (this.key.up) {
												move_vector += Vector3.forward;
												is_moved = true;			
										}
										if (this.key.down) {
												move_vector += Vector3.back; 
												is_moved = true;
										}
								}
								break;
						case 1:
								{
										if (this.key.right) {
												move_vector += Vector3.forward; //移動用ベクトルを右に向ける.
												is_moved = true;			//移動中フラグをたてる.
										}
			
										if (this.key.left) {
												move_vector += Vector3.back;
												is_moved = true;
										}
										if (this.key.up) {
												move_vector += Vector3.left;
												is_moved = true;			
										}
										if (this.key.down) {
												move_vector += Vector3.right; 
												is_moved = true;
										}
								}
								break;
						case 2:
								{
										if (this.key.right) {
												move_vector += Vector3.left; //移動用ベクトルを右に向ける.
												is_moved = true;			//移動中フラグをたてる.
										}
			
										if (this.key.left) {
												move_vector += Vector3.right;
												is_moved = true;
										}
										if (this.key.up) {
												move_vector += Vector3.back;
												is_moved = true;			
										}
										if (this.key.down) {
												move_vector += Vector3.forward; 
												is_moved = true;
										}
								}
								break;
						case 3:
								{
										if (this.key.right) {
												move_vector += Vector3.back; //移動用ベクトルを右に向ける.
												is_moved = true;			//移動中フラグをたてる.
										}
			
										if (this.key.left) {
												move_vector += Vector3.forward;
												is_moved = true;
										}
										if (this.key.up) {
												move_vector += Vector3.right;
												is_moved = true;			
										}
										if (this.key.down) {
												move_vector += Vector3.left; 
												is_moved = true;
										}
								}
								break;

						}
						move_vector.Normalize ();//長さを１に.
						move_vector *= MOVE_SPEED * Time.deltaTime;//速度×時間＝距離.
						position += move_vector;

						//実際の位置を新しく求めた位置に変更.
						this.transform.position = position;

						if (move_vector.magnitude > 0.01f) {
								Quaternion q = Quaternion.LookRotation (move_vector, Vector3.up);
								this.transform.rotation =
				Quaternion.Lerp (this.transform.rotation, q, 0.1f);
						}
				}

	}
	// Update is called once per frame
	void Update () {
			this.get_input ();


		while (this.next_step != STEP.NONE) {
			this.step = this.next_step;
			this.next_step = STEP.NONE;
			switch(this.step){
			case STEP.MOVE:
				break;
			}
			this.step_timer = 0.0f;
		}
		switch (this.step) {
		case STEP.MOVE:
			this.move_control();
			break;
		}
	}
}
