using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imageSwap : MonoBehaviour {
    public int timeTillSwap = 0;
	// Use this for initialization
	void Start () {
        StartCoroutine(swapStuff());
	}
	IEnumerator swapStuff()
    {
        yield return new WaitForSeconds(timeTillSwap);
        GetComponent<Transform>().position = new Vector3(0,800, 0);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
