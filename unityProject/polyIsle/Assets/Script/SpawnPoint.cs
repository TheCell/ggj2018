using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

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
            other.GetComponent<Player>().spawnPoint = GetComponent<Transform>();
        }
    }
}
