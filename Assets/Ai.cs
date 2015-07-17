using UnityEngine;
using System.Collections;

public class Ai : MonoBehaviour {

    public GameObject player = null;
    private NavMeshAgent agent;
    private NavMeshPath path;
    public Amount playerHealth;
    public bool spiderDie;

	// Use this for initialization
	void Start () {
        if (player == null)
            player = GameObject.Find("unitychan");
        spiderDie = false;

        agent = transform.GetComponent<NavMeshAgent>();
        path = new NavMeshPath();
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
        agent.CalculatePath(player.transform.position, path);
        agent.SetPath(path);
        decideAction();
    }

    void decideAction() {
        var distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance < 3.5) {
            if (!GetComponent<Animation>().IsPlaying("Attack")) {
    	       GetComponent<Animation>().PlayQueued("Attack", QueueMode.PlayNow);
               playerHealth.attackedBySpider();
            }
            //GetComponent<Animation>().PlayQueued("Idle", QueueMode.CompleteOthers);
            //GetComponent<Animation>().PlayQueued("Idle", QueueMode.CompleteOthers);
            //isPlaying = false;
    	} else {
            if (!GetComponent<Animation>().IsPlaying("Run"))
                GetComponent<Animation>().PlayQueued("Run", QueueMode.CompleteOthers);
        }
    	return;
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
