using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalWall : MonoBehaviour {
    private SpriteRenderer sprite;
    private Sprite originalSprite;
    private Collider2D ownCollider;
    public Sprite changeSprite;
    public float waitTime;
    private GameObject player;


	// Use this for initialization
	void Start () {
        sprite = gameObject.GetComponent<SpriteRenderer>();
        originalSprite = sprite.sprite;
        ownCollider = gameObject.GetComponent<Collider2D>();
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("HIT");
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        sprite.sprite = changeSprite;
        ownCollider.enabled = false;
        yield return new WaitForSecondsRealtime(waitTime);
        ownCollider.enabled = true;
        sprite.sprite = originalSprite;
        if (Mathf.Abs(player.transform.position.x - gameObject.transform.position.x) < .15f)
        {
            player.SetActive(false);
        }
    }
}
