using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour {

    public float resetX = 0;
    public float resetY = 0;
    public float resetZ = 20;
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
            other.GetComponent<Transform>().position = new Vector3(other.GetComponent<Transform>().position.x - resetX, other.GetComponent<Transform>().position.y - resetY, other.GetComponent<Transform>().position.z - resetZ);
        }
    }
}
