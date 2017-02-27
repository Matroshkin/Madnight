using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {

    public float interactDistance = 5f;
    private bool dead = false;
    public CharacterController cc;

    private void Start()
    {
       // Die();
    }
    // Update is called once per frame
    
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, interactDistance))
            {
                if (hit.collider.CompareTag("door"))
                {
                    hit.collider.GetComponent<DoorOpen>().ChangeDoorState();
                }
                if (hit.collider.CompareTag("tv"))
                {
                    hit.collider.GetComponent<TVInteract>().InteractTV();
                }
                if (hit.collider.CompareTag("notes"))
                {
                    hit.collider.GetComponent<NoteScript>().NoteInteract();
                }
            }

        }
        if ((dead) & (transform.position.y > -3.5f)) transform.position = new Vector3(transform.position.x, -3.3f, transform.position.z);
        

    }
    public void Die()
    {
        dead = true;
        cc.enabled = false;
    }
}
