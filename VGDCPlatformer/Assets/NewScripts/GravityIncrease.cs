using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityIncrease : MonoBehaviour {
    Rigidbody2D player;
    GameObject uiShit;
    GameObject uiShit2;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
	}

    private void Awake()
    {
        uiShit = GameObject.Find("IncreasedGravityUI");
        uiShit2 = GameObject.Find("DecreasedGravityUI");
    }

    // Update is called once per frame
    void Update () {

}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("GravityIncreasing");
            player.gravityScale = 7;
            uiShit.SetActive(true);
            uiShit2.SetActive(false);
        }
    }

}
