using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
    GameObject menu;
    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        menu = GameObject.FindGameObjectWithTag("Menu");
            menu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.P))
        {
            menu.SetActive(true);
            Time.timeScale = 0.0f;
            player.GetComponent<PlayerMovementBeginner>().enabled = false;
        }
	}
}
