using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVInteract : MonoBehaviour {

    //public bool TVShow = false;
    public AudioSource audio;
    public Light light;
    //public Plane screen;
    public GameObject screenGO;
    public Renderer screenRenderer;
    //public Material screenTexture;
    private int tvState = 0;
    public bool timeToScare = false;
    public Material tvMat, camMat;
    public GameObject scaryStaff;
    public DoorOpen doorScary;

	// Use this for initialization
	void Start () {
        ChangeTV(1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeTV(int state)
    {
        tvState = state;
        if(tvState == 0)
        {
            scaryStaff.SetActive(false);
            audio.Stop();
            light.enabled = false;
            screenGO.SetActive(false);
            screenRenderer.material = tvMat;
        }
        if (tvState == 1)
        {
            scaryStaff.SetActive(false);
            audio.Play();
            light.enabled = true;
            screenGO.SetActive(true);
            screenRenderer.material = tvMat;
        }
        if (tvState == 2)
        {
            scaryStaff.SetActive(true);
            audio.Stop();
            light.enabled = true;
            screenGO.SetActive(true);
            screenRenderer.material = camMat;
            tvState = 1;
            doorScary.allowToOpen = true;
            doorScary.open = true;
            //screen.mate
        }
    }

    public void InteractTV()
    {
        if (timeToScare)
        { ChangeTV(2); timeToScare = false; }
        else
        if (tvState == 0)
            ChangeTV(1);
        else
        if (tvState == 1)
            ChangeTV(0);
        
    }

    public void TurnOffScaryStaff()
    {
        scaryStaff.SetActive(false);
        if (tvState == 1) ChangeTV(1); else
        if (tvState == 0) ChangeTV(0);
    }
}
