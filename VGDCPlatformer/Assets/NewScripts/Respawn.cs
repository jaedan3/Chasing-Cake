using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
    private GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (player.activeSelf == false)
        {
            player.transform.position = transform.position;
            StartCoroutine(respawn());
        }
	}

    IEnumerator respawn()
    {
        yield return new WaitForSecondsRealtime(3);
        
        player.SetActive(true);
    }
}
