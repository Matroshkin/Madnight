using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour {

    public GameObject player;
    public GameObject startCamera;
    public GameObject startMenu;
    public AudioSource ambientSound;
    public TVInteract tvScript;
    public AudioClip gameSound;
    public FlickeringLight flickLight;
    public GameObject image1, image2, image3;
    private float imageLive = 0f;
    public GameObject someScaryMore;

    private int gameState = 0;

    public void StartGame()
    {
        player.SetActive(true);
        startCamera.SetActive(false);
        startMenu.SetActive(false);
        gameState = 1;
        tvScript.ChangeTV(0);
        ambientSound.clip = gameSound;
        ambientSound.Play(44100);
        flickLight.flickering = false;
    }
    private void Update()
    {
        imageLive -= Time.deltaTime;
        if(imageLive<0)
        {
            image1.SetActive(false);
            image2.SetActive(false);
            image3.SetActive(false);
        }
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void ExecuteState()
    {
        gameState++;
        switch(gameState)
        {
            case 2:
                image1.SetActive(true);
                imageLive = 3f;
                tvScript.ChangeTV(1);
                flickLight.flickering = true;
                break;
            case 3:
                tvScript.timeToScare = true;
                tvScript.ChangeTV(0);
                image2.SetActive(true);
                imageLive = 3f;
                flickLight.flickering = false;
                flickLight.light.color = Color.red;
                break;
                
            case 4:
                image3.SetActive(true);
                imageLive = 3f;
                someScaryMore.SetActive(true);
                break;
        }
    }
}
