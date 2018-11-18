using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRespawn : MonoBehaviour {
    public GameObject respawnPoint;
    SpriteRenderer sprite;
    public Sprite originalSprite;
    public Sprite newSprite;

	// Use this for initialization
	void Start () {
        sprite = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (respawnPoint.transform.position != transform.position)
        {
            sprite.sprite = originalSprite;
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        respawnPoint.transform.position = transform.position;
        sprite.sprite = newSprite;
    }
}
