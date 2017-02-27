using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightingModel : MonoBehaviour {

    private Color startColor;
    private Renderer renderer;

	void Start () {
        renderer = GetComponent<Renderer>();
        startColor = renderer.material.color;
	}

    void OnMouseEnter()
    {
        renderer.material.color = Color.yellow;
    }
    void OnMouseExit()
    {
        renderer.material.color = startColor;
    }
}

