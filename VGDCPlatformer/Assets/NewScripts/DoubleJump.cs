using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour {
    PlayerMovementBeginner player;
    GameObject uiShit;

    // Use this for initialization
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovementBeginner>();


    }

    private void Awake()
    {
        uiShit = GameObject.Find("DoubleJumpUI");
    }

    // Update is called once per frame
    void Update () {
        
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.changeDoubleJump(true);
            uiShit.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.changeDoubleJump(false);
        }
    }
}
