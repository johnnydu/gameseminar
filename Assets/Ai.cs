using UnityEngine;
using System.Collections;

public class Ai : MonoBehaviour {

    public GameObject player = null;
    private NavMeshAgent agent;
    private NavMeshPath path;
    public Amount playerHealth;

	// Use this for initialization
	void Start () {
        if (player == null)
            player = GameObject.Find("unitychan");

        agent = transform.GetComponent<NavMeshAgent>();
        path = new NavMeshPath();
	}
	
	// Update is called once per frame
	void Update () {
        if (!playerHealth.isPlayerDead()) {
            Play();
        } else {
            GameOver();
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
               playerHealth.damaged();
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

    //void OnCollisionEnter(Collision collision){
    //    Debug.Log("collide");
    //    if(collision.gameObject.CompareTag("Player")) {
    //      playerHealth.damaged();
    //    }
    //}

    void GameOver() {
        agent.Stop();
        if (!GetComponent<Animation>().isPlaying) {
            Application.LoadLevel (2);
        }
    }
}
