using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTransparency : MonoBehaviour {

    public Material[] material;
    private GameObject[] wallList;
    private int materialIndex;
    void Start () {
        wallList = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
            wallList[i] = transform.GetChild(i).gameObject;
    }
	
	void Update () {
        if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            materialIndex--;
            if (materialIndex <0)
                materialIndex = 1;

            foreach(GameObject go in wallList)
                go.GetComponent<Renderer>().sharedMaterial = material[materialIndex];
        }
    
    }
}
