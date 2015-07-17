using UnityEngine;
using System.Collections;

public class flavios_butt : MonoBehaviour {
	GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collision) {
		if(collision.gameObject.CompareTag("portalfujii")) {
        	player.transform.position = GameObject.Find("portalnattaon").transform.position;
    	}

    	if(collision.gameObject.CompareTag("portalnattaon")) {
        	player.transform.position = GameObject.Find("portalfujii").transform.position;
    	}
    }
}
