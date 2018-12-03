using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostTile : MonoBehaviour {
    PlayerMovementBeginner player;
    GameObject UIShit;
    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovementBeginner>();
        
    }

    private void Awake()
    {
        UIShit = GameObject.Find("SpeedUI");
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Speedup");
            player.setSpeedMultiplier(2);
            UIShit.SetActive(true);

        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Speedup");
            player.setSpeedMultiplier(2);
        }
    }
}
