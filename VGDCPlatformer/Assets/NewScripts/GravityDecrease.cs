using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityDecrease : MonoBehaviour {
    Rigidbody2D player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("GravityDecreasing");
            player.gravityScale = 2;
        }
    }
}
