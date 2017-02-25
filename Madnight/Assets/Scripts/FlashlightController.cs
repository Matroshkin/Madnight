using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightController : MonoBehaviour {

    public Light flashLight;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.F))
            flashLight.enabled = !flashLight.enabled;
    }
}
