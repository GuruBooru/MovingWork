using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCam : MonoBehaviour {
    public WebCamTexture web;
    // Use this for initialization
    void Start () {
         web = new WebCamTexture(1280, 720, 60);
        GetComponent<MeshRenderer>().material.mainTexture = web;
        web.Play();

    }
	public void stopWeb()
    {
        web.Stop();
    }
	// Update is called once per frame
	void Update () {
		
	}
}
