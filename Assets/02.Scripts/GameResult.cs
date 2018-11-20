using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameResult : MonoBehaviour {
    private int score;
    private int bestScore;
    public GameObject result;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (GoalArea.goal || Out.isOut) {
            result.SetActive(true);
        }
	}
}
