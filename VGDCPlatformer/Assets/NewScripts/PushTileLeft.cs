using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PushTileLeft : MonoBehaviour {
    PlayerMovementBeginner player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovementBeginner>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    /*IEnumerator waittest()
    {
        Debug.Log("wait");
        yield return new WaitForSecondsRealtime(3);
        Debug.Log("wait 2");
    }*/

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //StartCoroutine(waittest());
            player.changePosition(player.transform.position.x - 1, player.transform.position.y, player.transform.position.z);
            player.changePosition(player.transform.position.x - 1, player.transform.position.y, player.transform.position.z);
            player.changePosition(player.transform.position.x - 1, player.transform.position.y, player.transform.position.z);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {

        }
    }
}
