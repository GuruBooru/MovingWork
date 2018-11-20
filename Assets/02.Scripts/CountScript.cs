using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountScript : MonoBehaviour {

    public bool CounterDownDone = false;
    public GameObject CountDown;
    public WebCam w;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (CounterDownDone)
        {

            CountDown.SetActive(false);
			Application.LoadLevel("Map_Desert1");
			Application.LoadLevelAdditive("Game");
			Application.LoadLevelAdditive("Road");
			Application.LoadLevelAdditive("Obtacle");
            Application.LoadLevelAdditive("GameOver");
            w.stopWeb();
        }
	}
}
