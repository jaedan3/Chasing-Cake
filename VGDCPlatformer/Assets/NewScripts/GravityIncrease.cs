using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityIncrease : MonoBehaviour {
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
            Debug.Log("GravityIncreasing");
            player.gravityScale = 2;
        }
    }
// Resets the gravityScale back to 1
/*
    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            player.gravityScale = 1;

        }
    }
*/
}
