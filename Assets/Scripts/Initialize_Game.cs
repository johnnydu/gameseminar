using UnityEngine;
using UnityEngine.UI;
using System.Collections;

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

	//int waitTime = 100;

	// Use this for initialization
	void Start () {
		balls = new GameObject[] { 
				(GameObject) Instantiate(ball, new Vector3(-3, 1.3f, 0), ball.transform.rotation),
				(GameObject) Instantiate(ball, new Vector3(-2, 1.3f, 0), ball.transform.rotation),
				(GameObject) Instantiate(ball, new Vector3(-1, 1.3f, 0), ball.transform.rotation),
				(GameObject) Instantiate(ball, new Vector3(0, 1.3f, 0), ball.transform.rotation),
				(GameObject) Instantiate(ball, new Vector3(1, 1.3f, 0), ball.transform.rotation),
				(GameObject) Instantiate(ball, new Vector3(2, 1.3f, 0), ball.transform.rotation),
				(GameObject) Instantiate(ball, new Vector3(3, 1.3f, 0), ball.transform.rotation) 
			};
		Instantiate(star, new Vector3(-3, 1.3f, 3), star.transform.rotation);
		Instantiate(star, new Vector3(-2, 1.3f, 3), star.transform.rotation);
		Instantiate(star, new Vector3(-1, 1.3f, 3), star.transform.rotation);
		Instantiate(star, new Vector3(0, 1.3f, 3), star.transform.rotation);
		Instantiate(star, new Vector3(1, 1.3f, 3), star.transform.rotation);
		Instantiate(star, new Vector3(2, 1.3f, 3), star.transform.rotation);
		Instantiate(star, new Vector3(3, 1.3f, 3), star.transform.rotation);

		//Invoke("respawnSpider", 7);
		//Invoke("respawnSpider", 14);
		//Invoke("respawnSpider", 21);
		//Invoke("respawnSpider", 28);
		numOfBalls = balls.Length;
	}
	
	// Update is called once per frame
	void Update () {

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