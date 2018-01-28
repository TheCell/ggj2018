using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>() != null)
        {
            other.GetComponent<Transform>().position = other.GetComponent<Player>().spawnPoint.Find("SpawnPosition").GetComponent<Transform>().position;
            this.GetComponent<AudioSource>().Play();
        }
    }
}
