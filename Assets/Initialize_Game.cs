using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Initialize_Game : MonoBehaviour {
	public GameObject star;
	public GameObject ball;
	public GameObject spider;
	public GameObject[] myBalls;

	int waitTime = 100;

	// Use this for initialization
	void Start () {
		myBalls = new GameObject[] {

			(GameObject) Instantiate(ball, new Vector3(35, 1.5f,37), ball.transform.rotation), 
			(GameObject) Instantiate(ball, new Vector3(30, 1.5f,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(25, 1.5f,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20, 1.5f,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(15, 1.5f,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10, 1.5f,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(5, 1.5f,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-35, 1.5f,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-30, 1.5f,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-25, 1.5f,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20, 1.5f,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-15, 1.5f,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10, 1.5f,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-5, 1.5f,37), ball.transform.rotation),

			(GameObject) Instantiate(ball, new Vector3(35, 1.5f,-37), ball.transform.rotation), 
			(GameObject) Instantiate(ball, new Vector3(30, 1.5f,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(25, 1.5f,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20, 1.5f,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(15, 1.5f,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10, 1.5f,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(5, 1.5f,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-35, 1.5f,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-30, 1.5f,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-25, 1.5f,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20, 1.5f,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-15, 1.5f,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10, 1.5f,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-5, 1.5f,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(0, 1.5f,-37), ball.transform.rotation),

			(GameObject) Instantiate(ball, new Vector3(35, 1.5f,27), ball.transform.rotation), 
			(GameObject) Instantiate(ball, new Vector3(30, 1.5f,27), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(25, 1.5f,27), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(15, 1.5f,27), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(5, 1.5f,27), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-35, 1.5f,27), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-30, 1.5f,27), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-25, 1.5f,27), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-15, 1.5f,27), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-5, 1.5f,27), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(0, 1.5f,27), ball.transform.rotation),


			(GameObject) Instantiate(ball, new Vector3(30, 1.5f,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(25, 1.5f,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-30, 1.5f,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-25, 1.5f,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(0, 1.5f,10), ball.transform.rotation),

			(GameObject) Instantiate(ball, new Vector3(30, 1.5f,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(25, 1.5f,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(5, 1.5f,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-30, 1.5f,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-25, 1.5f,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-5, 1.5f,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(0, 1.5f,-10), ball.transform.rotation),

			(GameObject) Instantiate(ball, new Vector3(30, 1.5f,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(25, 1.5f,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(15, 1.5f,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(5, 1.5f,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-30, 1.5f,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-25, 1.5f,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-15, 1.5f,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-5, 1.5f,-20), ball.transform.rotation),

			(GameObject) Instantiate(ball, new Vector3(30, 1.5f,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(15, 1.5f,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(5, 1.5f,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-30, 1.5f,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-15, 1.5f,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-5, 1.5f,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(0, 1.5f,-25), ball.transform.rotation),


			(GameObject) Instantiate(ball, new Vector3(30, 1.5f,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(25, 1.5f,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(5, 1.5f,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-30, 1.5f,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-25, 1.5f,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-5, 1.5f,-30), ball.transform.rotation),

			(GameObject) Instantiate(ball, new Vector3(37, 1.5f,-35), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37, 1.5f,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37, 1.5f,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37, 1.5f,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37, 1.5f,-15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37, 1.5f,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37, 3,0), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37, 1.5f,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37, 1.5f,15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37, 1.5f,20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37, 1.5f,25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37, 1.5f,30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37, 1.5f,35), ball.transform.rotation),

			(GameObject) Instantiate(ball, new Vector3(-37, 1.5f,-35), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37, 1.5f,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37, 1.5f,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37, 1.5f,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37, 1.5f,-15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37, 1.5f,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37, 3,0), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37, 1.5f,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37, 1.5f,15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37, 1.5f,20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37, 1.5f,25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37, 1.5f,30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37, 1.5f,35), ball.transform.rotation),

			(GameObject) Instantiate(ball, new Vector3(-20, 1.5f,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20, 1.5f,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20, 1.5f,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20, 1.5f,-15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20, 1.5f,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20, 1.5f,-5), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20, 1.5f,0), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20, 1.5f,5), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20, 1.5f,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20, 1.5f,15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20, 1.5f,20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20, 1.5f,25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20, 1.5f,30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20, 1.5f,33.5f), ball.transform.rotation),

			(GameObject) Instantiate(ball, new Vector3(20, 1.5f,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20, 1.5f,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20, 1.5f,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20, 1.5f,-15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20, 1.5f,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20, 1.5f,-5), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20, 1.5f,0), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20, 1.5f,5), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20, 1.5f,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20, 1.5f,15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20, 1.5f,20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20, 1.5f,25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20, 1.5f,30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20, 1.5f,33.5f), ball.transform.rotation),

			(GameObject) Instantiate(ball, new Vector3(-10, 1.5f,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10, 1.5f,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10, 1.5f,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10, 1.5f,-15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10, 1.5f,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-11.5f, 1.5f,-5), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-11.5f, 1.5f,0), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-11.5f, 1.5f,5), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10, 1.5f,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10, 1.5f,15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10, 1.5f,20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10, 1.5f,25), ball.transform.rotation),

			(GameObject) Instantiate(ball, new Vector3(10, 1.5f,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10, 1.5f,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10, 1.5f,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10, 1.5f,-15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10, 1.5f,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(11.5f, 1.5f,-5), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(11.5f, 1.5f,0), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(11.5f, 1.5f,5), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10, 1.5f,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10, 1.5f,15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10, 1.5f,20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10, 1.5f,25), ball.transform.rotation),

			(GameObject) Instantiate(ball, new Vector3(30, 2, 0), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-30, 2, 0), ball.transform.rotation),


		};
		// Instantiate(star, new Vector3(-3, 1.3f, 3), star.transform.rotation);
		// Instantiate(star, new Vector3(-2, 1.3f, 3), star.transform.rotation);
		// Instantiate(star, new Vector3(-1, 1.3f, 3), star.transform.rotation);
		// Instantiate(star, new Vector3(0, 1.3f, 3), star.transform.rotation);
		// Instantiate(star, new Vector3(1, 1.3f, 3), star.transform.rotation);
		// Instantiate(star, new Vector3(2, 1.3f, 3), star.transform.rotation);
		Instantiate(star, new Vector3(3, 1.5f, 3), star.transform.rotation);

		Invoke("respawnSpider", 7);
		Invoke("respawnSpider", 14);
		Invoke("respawnSpider", 21);
		Invoke("respawnSpider", 28);

	}

	// Update is called once per frame
	void Update () {

		//if (spider1 == null) {
		//	spider1 = (GameObject) Instantiate(spider, new Vector3(-25.9f, 1f, 25.8f), gameObject.transform.rotation);
		//}
		//if (spider2 == null) {
		//	StartCoroutine(waitTimeForSpiderRespawn());
        //	spider2 = (GameObject) Instantiate(spider, new Vector3(24.5f, 1f, 25.8f), gameObject.transform.rotation);
    	//}
		//if (spider3 == null) {
		//	StartCoroutine(waitTimeForSpiderRespawn());
        //	spider3 = (GameObject) Instantiate(spider, new Vector3(20.7f, 1f, -26.1f), gameObject.transform.rotation);
    	//}
		//if (spider4 == null) {
		//	StartCoroutine(waitTimeForSpiderRespawn());
        //	spider4 = (GameObject) Instantiate(spider, new Vector3(-22.4f, 1f, -24.4f), gameObject.transform.rotation);
    	//}



	}

	public void respawnSpider() {
		//Instantiate(spider, new Vector3(0f, 0f, 0f), gameObject.transform.rotation);
	}

	public int getBallSize() {
		return myBalls.Length;
	}

}