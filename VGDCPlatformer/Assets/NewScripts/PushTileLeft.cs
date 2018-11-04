using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PushTileLeft : MonoBehaviour {
    PlayerMovementBeginner player;
    public float push;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovementBeginner>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator waittest()
    {
        yield return new WaitForSeconds(.1f);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            StartCoroutine(waittest());
            GameObject obj = collision.gameObject;
            Rigidbody2D rigid = obj.GetComponent<Rigidbody2D>();
            Debug.Log("check");
            rigid.velocity = new Vector2(-push,0);
            //player.changePosition(player.transform.position.x - 1, player.transform.position.y, player.transform.position.z);
            //player.changePosition(player.transform.position.x - 1, player.transform.position.y, player.transform.position.z);
            //player.changePosition(player.transform.position.x - 1, player.transform.position.y, player.transform.position.z);
        }
    }
    /*
    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {

        }
    }*/
}
