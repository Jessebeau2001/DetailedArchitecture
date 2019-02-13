using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTransparency : MonoBehaviour {

    public Material[] material;
    Renderer rend;

    void Start () {
        rend = GetComponentInChildren<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown("1"))
        {
            int children = transform.childCount;
            for (int i = 0; i < children; i++)
                rend.sharedMaterial = material[1];
        }
    }
}
