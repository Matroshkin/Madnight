using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScript : MonoBehaviour {

    public GameControllerScript gcs;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    public void NoteInteract()
    {
        gcs.ExecuteState();
        Debug.Log("Hi");
        gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        GameObject player = GameObject.Find("FirstPersonCharacter");
        if(Vector3.Distance(player.transform.position, this.transform.position)<3f)
        NoteInteract();

    }
}
