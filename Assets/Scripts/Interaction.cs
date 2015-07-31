using UnityEngine;
using System.Collections;

public class Interaction : MonoBehaviour {
	public Interface amount;
	public GameObject star;
	public GameObject player;
	public GameObject currStar;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("z"))
			throwStar();
        if (Initialize_Game.numOfBalls == amount.getNumBallsCollected()) {
            win();
        }

	}

	void OnTriggerEnter(Collider collision) {
		if(collision.gameObject.CompareTag("ball")) {
        	Destroy(collision.gameObject);
        	amount.pickUpBall();
    	}

    	if(collision.gameObject.CompareTag("shuriken")) {
        	Destroy(collision.gameObject);
        	amount.pickUpStar();
    	}

        if(collision.gameObject.CompareTag("portalRight")) {
            player.transform.position = GameObject.Find("portalLeft").transform.position + new Vector3(2, -5.6f, 0);
        }

        if(collision.gameObject.CompareTag("portalLeft")) {
            player.transform.position = GameObject.Find("portalRight").transform.position + new Vector3(-2, -5.6f, 0);
        }
    }

    void throwStar() {
    	if (amount.useStar()) {
    		currStar = (GameObject) Instantiate(star, transform.position + (transform.forward * 2) + (transform.up), player.transform.rotation * Quaternion.Euler(0, 90, 0));
            currStar.tag = "throwableShuriken";
    		currStar.GetComponent<Rigidbody>().useGravity = true;
    		currStar.GetComponent<Rigidbody>().AddForce( player.transform.forward * 2000 );
            currStar.GetComponent<Transform>().Rotate (0, 50*Time.deltaTime, 0);
    	}
    }

    // Winning Screen
    void win() {
        Application.LoadLevel (2);
    }
}
