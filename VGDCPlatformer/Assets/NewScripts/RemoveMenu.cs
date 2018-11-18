using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveMenu : MonoBehaviour {
    GameObject menuItems;
    GameObject player;

	// Use this for initialization
	void Start () {
          
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void RemoveItems()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        menuItems = GameObject.FindGameObjectWithTag("Menu");
        menuItems.SetActive(false);
        Time.timeScale = 1.0f;
        player.GetComponent<PlayerMovementBeginner>().enabled = true;
    }
}
