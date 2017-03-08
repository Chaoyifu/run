using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            Destroy(gameObject);
            GameInfo.Collection++;
        }
    }
}
