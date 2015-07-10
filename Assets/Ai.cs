using UnityEngine;
using System.Collections;

public class Ai : MonoBehaviour {

    public GameObject player = null;
    private NavMeshAgent agent;
    private NavMeshPath path;
    private bool isPlaying;

	// Use this for initialization
	void Start () {
        if (player == null)
            player = GameObject.Find("unitychan");

        agent = transform.GetComponent<NavMeshAgent>();
        path = new NavMeshPath();
        isPlaying = true;
	}
	
	// Update is called once per frame
	void Update () {

        if (isPlaying) {
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
            if (!GetComponent<Animation>().IsPlaying("Attack"))
    	       GetComponent<Animation>().PlayQueued("Attack", QueueMode.PlayNow);
            //GetComponent<Animation>().PlayQueued("Idle", QueueMode.CompleteOthers);
            //GetComponent<Animation>().PlayQueued("Idle", QueueMode.CompleteOthers);
            //isPlaying = false;
    	} else {
            if (!GetComponent<Animation>().IsPlaying("Run"))
                GetComponent<Animation>().PlayQueued("Run", QueueMode.CompleteOthers);
        }
    	return;
    }

    void GameOver() {
        agent.Stop();
        // Fade.use.Alpha(guiTexture, 1.0, 0.0, 3.0);
        if (!GetComponent<Animation>().isPlaying) {
            Application.LoadLevel (2);
        }
    }
}
