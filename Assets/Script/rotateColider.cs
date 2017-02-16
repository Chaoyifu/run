using UnityEngine;
using System.Collections;

public class rotateColider : MonoBehaviour {

    void Start() {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("111");
        Quaternion rot = other.transform.rotation;
        rot.x = -180f;
        other.transform.rotation = rot;
        other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y - 3, other.transform.position.z);
    }
}
