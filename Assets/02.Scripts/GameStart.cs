using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour {

	private GameObject roadManager;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartGame() {
		//SceneManager.LoadScene("Map_Desert1");
		//SceneManager.LoadScene("Game");
		//SceneManager.LoadScene("Road");

		Application.LoadLevel("countDown");
        Application.LoadLevelAdditive("ShowMe");
//		Application.LoadLevelAdditive("Map_Desert1");
//		Application.LoadLevelAdditive("Game");
//		Application.LoadLevelAdditive("Road");
		//LoadGame ();
	}

//	IEnumerator WaitForIt() {
//		yield return new WaitForSeconds (6.0f);
//		Application.LoadLevelAdditive("Map_Desert1");
//		Application.LoadLevelAdditive("Game");
//		Application.LoadLevelAdditive("Road");
//	}
}
