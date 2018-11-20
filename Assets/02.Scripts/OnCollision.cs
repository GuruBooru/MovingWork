using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour {

    // Use this for initialization
    public float heartcount = 3.0f;
    public Renderer heart1;
    public Renderer heart2;
    public Renderer heart3;

    void Start () {
    }
    
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Click()
    {
        heartcount--;
        if (heartcount == 2)
        {
            heart1.material.SetColor("_Color",Color.gray);
        }
        if (heartcount == 1)
        {
            heart2.material.SetColor("_Color", Color.gray);
        }
        if (heartcount == 0)
        {
            heart3.material.SetColor("_Color", Color.gray);
            Application.LoadLevel("GameOver");
        }
    }
}
