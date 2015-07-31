using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Initialize_Game : MonoBehaviour {
	public GameObject star;
	public GameObject ball;
	public GameObject spider;
	public GameObject[] myBalls;
	
	int waitTime = 100;
	float ball_y_pos =3.5f;
	
	// Use this for initialization
	void Start () {
		myBalls = new GameObject[] {
			
			(GameObject) Instantiate(ball, new Vector3(35,ball_y_pos,37), ball.transform.rotation), 
			(GameObject) Instantiate(ball, new Vector3(30,ball_y_pos,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(25,ball_y_pos,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20,ball_y_pos,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(15,ball_y_pos,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10,ball_y_pos,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(5,ball_y_pos,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-35,ball_y_pos,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-30,ball_y_pos,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-25,ball_y_pos,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20,ball_y_pos,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-15,ball_y_pos,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10,ball_y_pos,37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-5,ball_y_pos,37), ball.transform.rotation),
			
			(GameObject) Instantiate(ball, new Vector3(35,ball_y_pos,-37), ball.transform.rotation), 
			(GameObject) Instantiate(ball, new Vector3(30,ball_y_pos,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(25,ball_y_pos,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20,ball_y_pos,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(15,ball_y_pos,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10,ball_y_pos,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(5,ball_y_pos,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-35,ball_y_pos,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-30,ball_y_pos,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-25,ball_y_pos,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20,ball_y_pos,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-15,ball_y_pos,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10,ball_y_pos,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-5,ball_y_pos,-37), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(0,ball_y_pos,-37), ball.transform.rotation),
			
			(GameObject) Instantiate(ball, new Vector3(35,ball_y_pos,27), ball.transform.rotation), 
			(GameObject) Instantiate(ball, new Vector3(30,ball_y_pos,27), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(25,ball_y_pos,27), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(15,ball_y_pos,27), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(5,ball_y_pos,27), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-35,ball_y_pos,27), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-30,ball_y_pos,27), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-25,ball_y_pos,27), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-15,ball_y_pos,27), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-5,ball_y_pos,27), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(0,ball_y_pos,27), ball.transform.rotation),
			
			
			(GameObject) Instantiate(ball, new Vector3(30,ball_y_pos,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(25,ball_y_pos,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-30,ball_y_pos,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-25,ball_y_pos,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(0,ball_y_pos,10), ball.transform.rotation),
			
			(GameObject) Instantiate(ball, new Vector3(30,ball_y_pos,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(25,ball_y_pos,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(5,ball_y_pos,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-30,ball_y_pos,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-25,ball_y_pos,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-5,ball_y_pos,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(0,ball_y_pos,-10), ball.transform.rotation),
			
			(GameObject) Instantiate(ball, new Vector3(30,ball_y_pos,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(25,ball_y_pos,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(15,ball_y_pos,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(5,ball_y_pos,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-30,ball_y_pos,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-25,ball_y_pos,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-15,ball_y_pos,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-5,ball_y_pos,-20), ball.transform.rotation),
			
			(GameObject) Instantiate(ball, new Vector3(30,ball_y_pos,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(15,ball_y_pos,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(5,ball_y_pos,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-30,ball_y_pos,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-15,ball_y_pos,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-5,ball_y_pos,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(0,ball_y_pos,-25), ball.transform.rotation),
			
			
			(GameObject) Instantiate(ball, new Vector3(30,ball_y_pos,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(25,ball_y_pos,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(5,ball_y_pos,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-30,ball_y_pos,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-25,ball_y_pos,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-5,ball_y_pos,-30), ball.transform.rotation),
			
			(GameObject) Instantiate(ball, new Vector3(37,ball_y_pos,-35), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37,ball_y_pos,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37,ball_y_pos,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37,ball_y_pos,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37,ball_y_pos,-15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37,ball_y_pos,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37, 3,0), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37,ball_y_pos,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37,ball_y_pos,15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37,ball_y_pos,20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37,ball_y_pos,25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37,ball_y_pos,30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(37,ball_y_pos,35), ball.transform.rotation),
			
			(GameObject) Instantiate(ball, new Vector3(-37,ball_y_pos,-35), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37,ball_y_pos,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37,ball_y_pos,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37,ball_y_pos,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37,ball_y_pos,-15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37,ball_y_pos,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37, 3,0), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37,ball_y_pos,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37,ball_y_pos,15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37,ball_y_pos,20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37,ball_y_pos,25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37,ball_y_pos,30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-37,ball_y_pos,35), ball.transform.rotation),
			
			(GameObject) Instantiate(ball, new Vector3(-20,ball_y_pos,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20,ball_y_pos,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20,ball_y_pos,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20,ball_y_pos,-15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20,ball_y_pos,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20,ball_y_pos,-5), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20,ball_y_pos,0), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20,ball_y_pos,5), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20,ball_y_pos,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20,ball_y_pos,15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20,ball_y_pos,20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20,ball_y_pos,25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20,ball_y_pos,30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-20,ball_y_pos,33.5f), ball.transform.rotation),
			
			(GameObject) Instantiate(ball, new Vector3(20,ball_y_pos,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20,ball_y_pos,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20,ball_y_pos,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20,ball_y_pos,-15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20,ball_y_pos,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20,ball_y_pos,-5), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20,ball_y_pos,0), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20,ball_y_pos,5), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20,ball_y_pos,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20,ball_y_pos,15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20,ball_y_pos,20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20,ball_y_pos,25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20,ball_y_pos,30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(20,ball_y_pos,33.5f), ball.transform.rotation),
			
			(GameObject) Instantiate(ball, new Vector3(-10,ball_y_pos,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10,ball_y_pos,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10,ball_y_pos,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10,ball_y_pos,-15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10,ball_y_pos,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-11.5f,ball_y_pos,-5), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-11.5f,ball_y_pos,0), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-11.5f,ball_y_pos,5), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10,ball_y_pos,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10,ball_y_pos,15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10,ball_y_pos,20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-10,ball_y_pos,25), ball.transform.rotation),
			
			(GameObject) Instantiate(ball, new Vector3(10,ball_y_pos,-30), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10,ball_y_pos,-25), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10,ball_y_pos,-20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10,ball_y_pos,-15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10,ball_y_pos,-10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(11.5f,ball_y_pos,-5), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(11.5f,ball_y_pos,0), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(11.5f,ball_y_pos,5), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10,ball_y_pos,10), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10,ball_y_pos,15), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10,ball_y_pos,20), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(10,ball_y_pos,25), ball.transform.rotation),
			
			(GameObject) Instantiate(ball, new Vector3(30, 2, 0), ball.transform.rotation),
			(GameObject) Instantiate(ball, new Vector3(-30, 2, 0), ball.transform.rotation),
			
			
		};
		// Instantiate(star, new Vector3(-3, 1.3f, 3), star.transform.rotation);
		// Instantiate(star, new Vector3(-2, 1.3f, 3), star.transform.rotation);
		// Instantiate(star, new Vector3(-1, 1.3f, 3), star.transform.rotation);
		// Instantiate(star, new Vector3(0, 1.3f, 3), star.transform.rotation);
		// Instantiate(star, new Vector3(1, 1.3f, 3), star.transform.rotation);
		// Instantiate(star, new Vector3(2, 1.3f, 3), star.transform.rotation);
		Instantiate(star, new Vector3(3,ball_y_pos, 3), star.transform.rotation);
		
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