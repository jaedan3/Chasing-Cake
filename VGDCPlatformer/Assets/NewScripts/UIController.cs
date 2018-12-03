using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {
    GameObject[] uiThings;

	// Use this for initialization
	void Start () {
        uiThings = GameObject.FindGameObjectsWithTag("UIController");
        
        for (int i = 0; i < uiThings.Length; i++)
        {
            print(uiThings[i]);
            uiThings[i].SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
