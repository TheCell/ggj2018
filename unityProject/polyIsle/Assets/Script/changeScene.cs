using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(swapStuff());
    }
    IEnumerator swapStuff()
    {
        yield return new WaitForSeconds(24);
        Application.LoadLevel(1);
    }
}
