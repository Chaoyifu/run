using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaSlipeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "Player"){
            GameInfo.GameState = 1;
            Destroy(gameObject);
        }
    }
}
