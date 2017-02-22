using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinesSp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player"){
            Destroy(collision.gameObject);
        }
    }
}
