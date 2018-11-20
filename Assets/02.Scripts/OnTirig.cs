using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTirig : MonoBehaviour {
	private Image heart1, heart2, heart3;
	private int heartcount = 3;
	private bool isDamaged = false;

	// Use this for initialization
	void Start () {
		heart1 = GameObject.Find ("heart1").GetComponent<Image>();
		heart2 = GameObject.Find ("heart2").GetComponent<Image>();
		heart3 = GameObject.Find ("heart3").GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.transform.tag == "Player") {
			heartcount--;
			if (heartcount == 2)
			{
				Debug.Log ("heart2");
//				heart1.material = "";
				//heart1.material.color = Color.white;
			}
		}
	}
}
