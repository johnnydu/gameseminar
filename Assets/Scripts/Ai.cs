using UnityEngine;
using System.Collections;

public class Ai : MonoBehaviour {

    public GameObject player = null;
    private NavMeshAgent agent;
    private NavMeshPath path;
    public Interface playerHealth;
    public bool spiderDie;

    public GameObject[] map;

    public static GameObject[] spiders;

	// Use this for initialization
	void Start () {
        if (player == null)
            player = GameObject.Find("unitychan");
        spiderDie = false;

        agent = transform.GetComponent<NavMeshAgent>();
        path = new NavMeshPath();

        spiders = new GameObject[4];
    }
	
	// Update is called once per frame
	void Update () {
        if (spiderDie) {
            killSpider();
        } else if (!playerHealth.isPlayerDead()) {
            Play();
        } else {
            gameOver();
        }
	}

    void Play() {
        if (transform.position.y > -10 && transform.position.y < 10) {
            decideAction();
        }
    }

    void decideAction() {
        /**
        if (spiders[0] == gameObject) {
            blinkly();
        } else if (spiders[1] == gameObject) {
            blinkly();
        } else if (spiders[2] == gameObject) {
            inky();
        } else if (spiders[3] == gameObject) {
            inky();
        } else {
            inky();
        }
        */

        blinkly();

    }

    void blinkly() {
        agent.CalculatePath(player.transform.position, path);
        agent.SetPath(path);
        attackAnimation();
        return;
    }

    void inky() {
        agent.CalculatePath(player.transform.position + (transform.forward * 6), path);
        agent.SetPath(path);
        attackAnimation();
        return;
    }


    void attackAnimation() {
        var distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance < 3.5) {
            if (!GetComponent<Animation>().IsPlaying("Attack")) {
               GetComponent<Animation>().PlayQueued("Attack", QueueMode.PlayNow);
               playerHealth.attackedBySpider();
            }
        } else {
            if (!GetComponent<Animation>().IsPlaying("Run"))
                GetComponent<Animation>().PlayQueued("Run", QueueMode.CompleteOthers);
        }
    }

    void OnTriggerEnter(Collider collision) {
        if (!GetComponent<Animation>().IsPlaying("Death")) {
            if(collision.gameObject.CompareTag("throwableShuriken")) {
                Destroy(collision.gameObject);
                GetComponent<Animation>().PlayQueued("Death", QueueMode.PlayNow);
                spiderDie = true;
            }
        }
    }

    void killSpider() {
        agent.Stop();
        if (!GetComponent<Animation>().IsPlaying("Death"))
           Destroy(gameObject);
    }

    // Losing Screen
    void gameOver() {
        if (!GetComponent<Animation>().isPlaying) {
            Application.LoadLevel (2);
        }
    }
}
