using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaryAttack : MonoBehaviour {

    Animator animator;
    private float timer = 999f;
    public PlayerInteract player;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if(timer<0) animator.SetBool("attack", false);
    }

    private void OnMouseEnter()
    {
        animator.SetBool("attack", true);
        timer = 2f;
        player.Die();
        //animator.SetBool("attack", false);
    }
}
