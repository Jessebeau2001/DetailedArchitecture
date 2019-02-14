using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTransparency : MonoBehaviour {

    public Material[] material;
    Renderer rend;
    private GameObject[] wallList; // new test code

    void Start () {
        wallList = new GameObject[transform.childCount]; // new test code

        for (int i = 0; i < transform.childCount; i++)
            wallList[i] = transform.GetChild(i).gameObject;


    }
	
	void Update () {
        if(Input.GetKeyDown("1"))
        {
            foreach(GameObject go in wallList)
                go.GetComponent<Renderer>().sharedMaterial = material[1];            
        }
    }
}
