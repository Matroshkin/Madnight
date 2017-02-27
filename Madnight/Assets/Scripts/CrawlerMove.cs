using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrawlerMove : MonoBehaviour {

    private float time = 3f;
    public TVInteract tvScript;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left*0.02f);
        time -= Time.deltaTime;
        if (time < 0) tvScript.TurnOffScaryStaff();
	}
}
