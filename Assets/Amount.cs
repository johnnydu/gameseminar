using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Amount : MonoBehaviour {
	 public Text scoreText;
	 public Slider hp;
	 public GameObject player = null;
	 public GameObject spider = null;
	 public GameObject coins = null;
	 int score;

	// Use this for initialization
	void Start () {
		if (player == null)
       	    player = GameObject.Find("unitychan");
       	if (spider == null)
       	    spider = GameObject.Find("SPIDER");
		score = 0;
		scoreText.text = score.ToString();
		hp.value = 100;
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = score.ToString();
		if (!spider.GetComponent<Animation>().IsPlaying("Attack") 
			&& !player.GetComponent<Animation>().IsPlaying("angry1@unitychan")) {

			hp.value -= 5;
			player.GetComponent<Animation>().Play("angry1@unitychan");

		}
		if (isPlayerDead()) {
			player.GetComponent<Animation>().Play("angry2@unitychan");
		}
	}

	bool isPlayerDead() {
		return hp.value == 0;
	}
}
