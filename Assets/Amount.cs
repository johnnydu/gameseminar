using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Amount : MonoBehaviour {
	 
	 public GameObject player;
	 public Text scoreText = null;
	 public Text starsText = null;
	 public Slider hp;
	 public GameObject star;
	 int ballsCollected;
	 int score;
	 int stars;

	//public Text calibrationText=null;
	//public Text gestureText=null;

	// Use this for initialization
	void Start () {
		score = 0;
		stars = 0;
		ballsCollected = 0;
		hp.value = 100;

	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + score.ToString();
		starsText.text = "Stars: " + stars.ToString();
		//calibrationText.text = "calibration";
		//gestureText.text = "gesture";
		//for (int i = 0; i < stars; i++) {
			//Instantiate(ball, new Vector3(player.transform.position.x + 2, player.transform.position.y, player.transform.position.z), player.transform.rotation);
		//}

	}

	public void attackedBySpider() {
		hp.value -= 5;
	}

	public void pickUpBall() {
		if (hp.value < 100)
			hp.value += 1;
		score += 1;
		ballsCollected += 1;
	}

	public void pickUpStar() {
		stars += 1;
	}

	public bool useStar() {
		if (stars > 0) {
			stars -= 1;
			return true;
		}
		return false;
	}

	public int getNumBallsCollected() {
		return ballsCollected;
	}

	public bool isPlayerDead() {
		return hp.value == 0;
	}
}
