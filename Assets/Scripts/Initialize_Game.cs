using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Initialize_Game : MonoBehaviour {
	 public GameObject star;
	 public GameObject ball;
	 public GameObject spider;
	 public GameObject spider1 = null;
	 public GameObject spider2 = null;
	 public GameObject spider3 = null;
	 public GameObject spider4 = null;
	 public GameObject[] balls;

	 public static int numOfBalls;


	 public static int[][] walkable;
	 public static Dictionary<GameObject, int[]> nodePosition;
	 private bool setBall;

	// Use this for initialization
	void Start () {


		setBall = false;
		
		/**
		Instantiate(star, new Vector3(-3, 1.3f, 3), star.transform.rotation);
		Instantiate(star, new Vector3(-2, 1.3f, 3), star.transform.rotation);
		Instantiate(star, new Vector3(-1, 1.3f, 3), star.transform.rotation);
		Instantiate(star, new Vector3(0, 1.3f, 3), star.transform.rotation);
		Instantiate(star, new Vector3(1, 1.3f, 3), star.transform.rotation);
		Instantiate(star, new Vector3(2, 1.3f, 3), star.transform.rotation);
		Instantiate(star, new Vector3(3, 1.3f, 3), star.transform.rotation);
		*/
		
		

		//Invoke("respawnSpider", 7);
		//Invoke("respawnSpider", 14);
		//Invoke("respawnSpider", 21);
		//Invoke("respawnSpider", 28);
		numOfBalls = 100;
	}
	
	// Update is called once per frame
	void Update () {

		if (nodePosition == null) {
			nodePosition = AIMap.nodePosition;
		}

		if (walkable == null) {
			walkable = AIMap.walkable;
		}

		int count = 0;
		if (nodePosition != null && !setBall) {
			foreach (var nP in nodePosition) {
				if(walkable[nP.Value[0]][nP.Value[1]] == 1) {
					Instantiate(ball, nP.Key.transform.position + new Vector3(0, 0.7f, 0), ball.transform.rotation);
				}
				count += 1;
			}
			numOfBalls = count;
			setBall = true;
		}

		//if (spider1 == null) {
			//spider1 = (GameObject) Instantiate(spider, new Vector3(-25.9f, 1f, 25.8f), gameObject.transform.rotation);
			//Ai.setMode(spider1, 0);
		//}
		//if (spider2 == null) {
        //	spider2 = (GameObject) Instantiate(spider, new Vector3(24.5f, 1f, 25.8f), gameObject.transform.rotation);
        //	Ai.setMode(spider2, 1);
    	//}
		if (spider3 == null) {
        	spider3 = (GameObject) Instantiate(spider, new Vector3(21.4f, 1f, -25f), gameObject.transform.rotation);;
    	}
		//if (spider4 == null) {
        //	spider4 = (GameObject) Instantiate(spider, new Vector3(-22.4f, 1f, -24.4f), gameObject.transform.rotation);
        //	Ai.setMode(spider4, 3);
    	//}
	}

	//public void respawnSpider() {
	//	Instantiate(spider, new Vector3(0f, 0f, 0f), gameObject.transform.rotation);
	//}

	//IEnumerator respawnDelay() {
	//	yield return new WaitForSeconds(1f);
	//}
}