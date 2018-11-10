using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PushTileRight : MonoBehaviour
{
    PlayerMovementBeginner player;
    public float push;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovementBeginner>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator waittest()
    {
        yield return new WaitForSeconds(.1f);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            /*StartCoroutine(waittest());
            GameObject obj = collision.gameObject;
            Rigidbody2D rigid = obj.GetComponent<Rigidbody2D>();
            Debug.Log("check");
            rigid.velocity = new Vector2(-push,0);*/
            Vector3 pushLeft = new Vector3(push, 0, 0);
            player.transform.Translate(pushLeft * Time.deltaTime);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //Vector3 pushLeft = new Vector3(-20, 0, 0);
            //player.transform.Translate(pushLeft * Time.deltaTime);
        }
    }
}
