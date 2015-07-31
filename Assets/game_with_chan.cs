using UnityEngine;
using System.Collections;

public class game_with_chan : MonoBehaviour {
	public Amount amount;
    public Initialize_Game startOfGame;
	public GameObject star;
	public GameObject player;
	public GameObject currStar;

	public AudioClip sound_ball_clip;
	public float sound_ball_volumn;
	AudioSource audio;

	// Use this for initialization
	void Start () {

		audio = GetComponent<AudioSource>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("z"))
			throwStar();
        if (startOfGame.getBallSize() == amount.getNumBallsCollected()) {
            win();
        }
	}

	void OnTriggerEnter(Collider collision) {
		if(collision.gameObject.CompareTag("ball")) {
			audio.PlayOneShot(sound_ball_clip, sound_ball_volumn);
        	Destroy(collision.gameObject);
        	amount.pickUpBall();
    	}

    	if(collision.gameObject.CompareTag("shuriken")) {
        	Destroy(collision.gameObject);
        	amount.pickUpStar();

    	}

        if(collision.gameObject.CompareTag("portalfujii")) {
            player.transform.position = GameObject.Find("portalnattaon").transform.position + new Vector3(-2, -6, 0);
        }

        if(collision.gameObject.CompareTag("portalnattaon")) {
            player.transform.position = GameObject.Find("portalfujii").transform.position + new Vector3(2, -6, 0);
        }
    }

    void throwStar() {
    	if (amount.useStar()) {
    		currStar = (GameObject) Instantiate(star, transform.position + (transform.forward * 2) + (transform.up * 2), player.transform.rotation * Quaternion.Euler(0, 90, 0));
            currStar.tag = "throwableShuriken";
    		currStar.GetComponent<Rigidbody>().useGravity = true;
    		currStar.GetComponent<Rigidbody>().AddForce( player.transform.forward * 2000 );
    	}
    }

    // Winning Screen
    void win() {
        Application.LoadLevel (2);
    }
}
