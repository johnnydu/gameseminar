//
// カメラ
// 
//
//
using UnityEngine;
using System.Collections;

namespace UnityChan
{
	public class PacmanCamera : MonoBehaviour
	{
		public float smooth = 3f;		// カメラモーションのスムーズ化用変数
		Transform standardPos;			// the usual position for the camera, specified by a transform in the game
		Transform frontPos;			// Front Camera locater
		Transform jumpPos;			// Jump Camera locater
		Transform firstCam;
		Transform thirdCam;
		Transform topCam;
		
		// スムーズに繋がない時（クイック切り替え）用のブーリアンフラグ
		bool bQuickSwitch = true;	//Change Camera Position Quickly
		
		private int current_view;
		
		void Start ()
		{
			// 各参照の初期化
			//standardPos = GameObject.Find ("CamPos").transform;
			current_view = 1;
			
			firstCam = GameObject.Find ("firstCam").transform;
			thirdCam = GameObject.Find ("thirdCam").transform;
			topCam = GameObject.Find ("topCam").transform;
			
			
			//カメラをスタートする
			transform.position = thirdCam.position;	
			transform.forward = thirdCam.forward;	
		}
		
		
		
		void FixedUpdate ()	// このカメラ切り替えはFixedUpdate()内でないと正常に動かない
		{
			
			if (Input.GetButtonDown ("Firstview")) {	// left Ctlr	
				current_view=1;
			} 
			else if (Input.GetButtonDown ("Thirdview")) {	//Alt	
				current_view=3;
			} 
			else if(Input.GetButtonDown ("Topview")){	
				current_view=5;
			}
			
			if(current_view==1)setCameraPositionFirstView ();
			else if(current_view==3)setCameraPositionThirdView ();
			else if(current_view==5)setCameraPositionTopView ();
		}
		void setCameraPositionFirstView ()
		{
			transform.position = firstCam.position;	
			transform.forward = firstCam.forward;
		}
		void setCameraPositionThirdView ()
		{
			//transform.position = Vector3.Lerp (transform.position, thirdCam.position, Time.fixedDeltaTime * smooth);	
			//transform.forward = Vector3.Lerp (transform.forward, thirdCam.forward, Time.fixedDeltaTime * smooth);
			transform.position = thirdCam.position;	
			transform.forward = thirdCam.forward;
			
		}
		
		void setCameraPositionTopView ()
		{
			
			transform.position = topCam.position;	
			transform.forward = topCam.forward;
		}

	}
}