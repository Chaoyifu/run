using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderRotation : MonoBehaviour {
   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionStay2D(Collision2D c)
    {
        if(c.gameObject.name == "Player"&& Input.GetKey(KeyCode.S))
        {
            c.transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, 180, 180);
            c.transform.position = new Vector3(c.transform.position.x, -3.5f, c.transform.position.z);
            Physics2D.gravity = new Vector3(0f, 10f, 0f);
        }
        if (c.gameObject.name == "Player" && Input.GetKey(KeyCode.W))
        {
            c.transform.localEulerAngles = new Vector3(transform.localEulerAngles.x,transform.localEulerAngles.y,transform.localEulerAngles.z);
            c.transform.position = new Vector3(c.transform.position.x, 1.5f, c.transform.position.z);
            Physics2D.gravity = new Vector3(0f, 10f, 0f);
        }
    }
}
  