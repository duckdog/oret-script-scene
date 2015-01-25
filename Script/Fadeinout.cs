using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Fadeinout : MonoBehaviour {

		private float lastStrong; //求めるライト強度(0.0～8.0)
		private float lightStrong; //現在ライト強度
		public float fadeSpeed; //フェードのスピード
	    public Image image = null;
	    public static float   alpha;

		void Start () {
		    lastStrong = 0.8f;
		    lightStrong = 8.0f;
			light.intensity = 8.0f;
		    alpha = 0.0f;
		this.image.color = new Color(0,0,0,alpha);
		}
		
		void Update () {
			//pilotScene fadeinsystem
			if(!pilotControl.stop){
			    //fade in
				if(lightStrong >= lastStrong)
				{
					lightStrong -= Time.deltaTime * fadeSpeed;
					light.intensity = lightStrong;
				}
		    }
		//sailor only fadeout
		fadeout_sailorOnly ();
		fadeout_pilotonly ();
		//day end
		fadeout_timeover ();
			
		}

	public void fadeout_sailorOnly(){

		if(SailorButton.fadeout){
			alpha +=  0.25f * Time.deltaTime;
			this.image.color = new Color(255,255,255,alpha);
			if(alpha >= 1){
				SailorButton.resultopen = true;
			}	
		}
	}
	public void fadeout_pilotonly(){
		//pilotScene fadeout
		if(PilotText.timerimit <= 0 && pilotControl.stop){
			alpha +=  0.2f * Time.deltaTime;
			this.image.color = new Color(0,0,0,alpha);
			if(alpha >= 1){
				TextData.playafter = true;
				pilotControl.stop = false;
				//alpha = 0.0f;
				Application.LoadLevel("GameScene");

			}	
		}
	}
	public void fadeout_timeover(){
		if(PlayerUI.timeover_fadeout){
			alpha +=  0.25f * Time.deltaTime;
			this.image.color = new Color(255,255,255,alpha);
			if(alpha >= 1){
				Application.LoadLevel("MoringScene");
			}	
		}
	}

}
