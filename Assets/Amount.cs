using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Amount : MonoBehaviour {
	 
	 public Text scoreText = null;
	 public Text starsText = null;
	 public Slider hp;
	 int score;
	 int stars;

	// Use this for initialization
	void Start () {
		score = 0;
		stars = 0;
		hp.value = 100;

	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + score.ToString();
		starsText.text = "Stars: " + stars.ToString();

	}

	public void damaged() {
		hp.value -= 5;
	}

	public void ball_collected() {
		if (hp.value < 100) {
			hp.value += 1;
		}
		score += 1;
	}

	public void star_collected() {
		stars += 1;
	}

	public bool isPlayerDead() {
		return hp.value == 0;
	}
}
