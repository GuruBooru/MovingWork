using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class Out : MonoBehaviour {
    public static bool isOut;
	// Use this for initialization
	void Start () {
        isOut = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player")) {
            isOut = true;
        }
    }
}
