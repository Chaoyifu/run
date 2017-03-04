using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateBackColider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "Player" && Input.GetKeyDown(KeyCode.S))
        {
            Quaternion rot = other.transform.rotation;
            rot.x = 0f;
            other.transform.rotation = rot;
            other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y + 1f, other.transform.position.z);
        }
    }
}
