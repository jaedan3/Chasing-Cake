using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PushTileRight : MonoBehaviour
{
    PlayerMovementBeginner player;
    public float newPos;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovementBeginner>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.changePosition(gameObject.transform.position.x+newPos, player.transform.position.y, player.transform.position.z);
            //Vector3 pushLeft = new Vector3(push, 0, 0);
            //player.transform.Translate(pushLeft * Time.deltaTime);
        }
    }
}
