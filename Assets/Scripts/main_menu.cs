using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 
public class main_menu : MonoBehaviour {
    public Button play;
 
    void Start () {
        play = play.GetComponent<Button> ();
 
    }

    public void pressPlay() {
    	Application.LoadLevel (1);
    }
}

