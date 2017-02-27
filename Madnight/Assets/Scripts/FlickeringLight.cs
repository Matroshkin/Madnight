using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour {

    public float minTime = 0.05f;
    public float maxTime = 1.2f;
    public bool flickering = true;
    private float timer;
    public Light light;

	// Use this for initialization
	void Start () {
        timer = Random.Range(minTime, maxTime);
	}
	
	// Update is called once per frame
	void Update () {
        if (flickering)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                light.enabled = !light.enabled;
                timer = Random.Range(minTime, maxTime);
            }
        }
	}
}
